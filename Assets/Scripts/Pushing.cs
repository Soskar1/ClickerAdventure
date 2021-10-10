using UnityEngine;

public class Pushing : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb2d;
    [SerializeField] private Vector2 _force;

    private void OnEnable() => Push();

    [ContextMenu("Толкнуть")]
    private void Push() => _rb2d.AddForce(_force, ForceMode2D.Impulse);
}
