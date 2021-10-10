using System;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler Instance { get; private set; }

    [Serializable]
    public struct ObjectInfo
    {
        public enum ObjectType
        { 
            Hero,
            Zombie,
            Currency,
            Chest
        }

        public ObjectType type;
        public GameObject prefab;
        public int startCount;
    }
    [SerializeField] private List<ObjectInfo> _objectsInfo;
    private Dictionary<ObjectInfo.ObjectType, Pool> _pools;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        InitPool();
    }

    private void InitPool()
    {
        _pools = new Dictionary<ObjectInfo.ObjectType, Pool>();

        var emptyObject = new GameObject();

        foreach (var obj in _objectsInfo)
        {
            var container = Instantiate(emptyObject, transform, false);
            container.name = obj.type.ToString();

            _pools[obj.type] = new Pool(container.transform);

            for (int index = 0; index < obj.startCount; index++)
            {
                var objectInstance = InstantiateObject(obj.type, container.transform);
                _pools[obj.type].objects.Enqueue(objectInstance);
            }
        }

        Destroy(emptyObject);
    }

    private GameObject InstantiateObject(ObjectInfo.ObjectType type, Transform parent)
    {
        var objectInstance = Instantiate(_objectsInfo.Find(x => x.type == type).prefab, parent);

        objectInstance.SetActive(false);
        return objectInstance;
    }

    public GameObject GetObject(ObjectInfo.ObjectType type)
    {
        var obj = _pools[type].objects.Count > 0 ?
            _pools[type].objects.Dequeue() : InstantiateObject(type, _pools[type].Container);

        obj.SetActive(true);

        return obj;
    }

    public void DestroyObject(GameObject obj)
    {
        _pools[obj.GetComponent<IPooledObject>().Type].objects.Enqueue(obj);
        obj.SetActive(false);
    }
}
