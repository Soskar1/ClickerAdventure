using UnityEngine;

namespace MainHero
{
    public class Movement : MonoBehaviour, IMove
    {
        [SerializeField] private float _speed;

        public void Move() => transform.Translate(Vector2.right * _speed * Time.deltaTime);

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<ICollectible>() != null)
                collision.GetComponent<ICollectible>().Collect();
        }
    }
}
