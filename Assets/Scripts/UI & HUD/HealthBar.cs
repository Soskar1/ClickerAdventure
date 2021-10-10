using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private Gradient _gradient;
    [SerializeField] private Image _fill;

    public void SetMaxHealth(float maxHealth)
    {
        _healthBar.maxValue = maxHealth;
        _healthBar.value = maxHealth;

        SetFillColor();
    }

    public void SetHealth(float health)
    {
        _healthBar.value = health;
        SetFillColor();
    }

    private void SetFillColor() => _fill.color = _gradient.Evaluate(_healthBar.normalizedValue);
}
