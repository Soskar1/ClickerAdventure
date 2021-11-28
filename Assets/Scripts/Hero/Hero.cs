using UnityEngine;

namespace MainHero
{
    [RequireComponent(typeof(Combat))]
    public class Hero : Entity
    {
        [SerializeField] private Combat _combat;
        private Controls _controls;
        private IMove _movement;

        private void Start()
        {
            _controls = new Controls();
            _controls.Disable();
            _controls.Player.Hit.performed += _ => _combat.Hit();

            _movement = GetComponent<IMove>();
        }

        private void OnDisable() => _controls.Disable();

        private void Update()
        {
            if (_combat.Entity == null)
            {
                if (_controls.Player.enabled)
                    _controls.Disable();

                _movement.Move();
            }
            else
            {
                if (!_controls.Player.enabled)
                    _controls.Enable();
            }
        }
    }
}
