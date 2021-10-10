using UnityEngine;

public class Reward : MonoBehaviour
{
    [SerializeField] private ObjectPooler.ObjectInfo.ObjectType _reward;
    [SerializeField] private int _amount;

    public void Drop()
    {
        for (int index = 0; index < _amount; index++)
        {
            GameObject entity = ObjectPooler.Instance.GetObject(_reward);
            entity.transform.position = transform.position;
        }
    }
}
