using UnityEngine;

namespace MainGame
{
    public class Settings : MonoBehaviour
    {
        [SerializeField] private int _maxFps;

        private void Awake()
        {
            Application.targetFrameRate = _maxFps;

            //Currency
            Physics2D.IgnoreLayerCollision(6, 6);

            //Currency & Enemy
            Physics2D.IgnoreLayerCollision(6, 7);
        }
    }
}
