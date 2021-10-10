using UnityEngine;

public class Combat : MonoBehaviour
{
    [SerializeField] private float _damage;

    private IHittable _entity;
    public IHittable Entity { get => _entity;}
    public float Damage { get => _damage; set => _damage = value; }

    public void Hit() => _entity.Hit(_damage);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponentInParent<IHittable>() != null)
            _entity = collision.GetComponentInParent<IHittable>();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision != null)
            _entity = null;
    }
}

