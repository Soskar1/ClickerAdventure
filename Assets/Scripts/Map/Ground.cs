using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private Spawner _spawner;

    public Transform endPosition;
    public Transform spawnPosition;

    public void Replace(Transform newPosition)
    {
        transform.position = newPosition.position;
        endPosition.gameObject.SetActive(true);
        _spawner.Spawn(spawnPosition.position);
    }
}
