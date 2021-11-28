using UnityEngine;

[RequireComponent(typeof(Health))]
[RequireComponent(typeof(Combat))]
public class ArithmeticAmplification : MonoBehaviour, IAmplification
{
    [SerializeField] private float _healthDifference;
    [SerializeField] private float _damageDifference;

    [SerializeField] private Health _health;
    [SerializeField] private Combat _combat;

    public void Amplify()
    {
        _health.MaxHealth += _healthDifference;
        _combat.Damage += _damageDifference;
    }
}
