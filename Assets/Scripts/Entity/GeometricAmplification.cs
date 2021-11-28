using UnityEngine;

[RequireComponent(typeof(Health))]
[RequireComponent(typeof(Combat))]
public class GeometricAmplification : MonoBehaviour, IAmplification
{
    [SerializeField] private float _healthMultiplier;
    [SerializeField] private float _damageMultiplier;

    [SerializeField] private Health _health;
    [SerializeField] private Combat _combat;

    public void Amplify()
    {
        _health.MaxHealth *= _healthMultiplier;
        _combat.Damage *= _damageMultiplier;
    }
}
