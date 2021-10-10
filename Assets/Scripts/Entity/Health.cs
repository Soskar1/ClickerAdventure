using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;

    [SerializeField] private float _maxHealth;
    public float MaxHealth { get => _maxHealth; set => _maxHealth = value; }

    private float _currentHealth;

    public Action Killed;

    private void Awake() => _currentHealth = _maxHealth;

    public void ReceiveDamage(float damage)
    {
        _currentHealth -= damage;
        _healthBar.SetHealth(_currentHealth);

        if (_currentHealth <= 0)
        {
            Killed?.Invoke();
            ResetHealth();
            ObjectPooler.Instance.DestroyObject(gameObject);
        }
    }

    public void ResetHealth()
    {
        _currentHealth = _maxHealth;
        _healthBar.SetMaxHealth(_maxHealth);
    }
}
