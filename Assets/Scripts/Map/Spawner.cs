using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<Entity> _entities;

    private Entity PickRandomEntity()
    {
        return _entities[Random.Range(0, _entities.Count)];
    }

    public void Spawn(Vector2 position)
    {
        IPooledObject randomEntity = PickRandomEntity().GetComponent<IPooledObject>();
        GameObject entity = ObjectPooler.Instance.GetObject(randomEntity.Type);
        entity.transform.position = position;
    }
}
