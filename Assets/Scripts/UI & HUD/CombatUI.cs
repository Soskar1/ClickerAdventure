using UnityEngine;
using TMPro;

public class CombatUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _entityName;
    [SerializeField] private HealthBar _healthBar;

    public void DisplayEntityData(EntityData entity)
    {
        _entityName.SetText(entity.name);
        _healthBar.SetMaxHealth(entity.maxHealth);
    }
}
