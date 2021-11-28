using UnityEngine;
using TMPro;

namespace MainGame.UI
{
    [RequireComponent(typeof(HealthBar))]
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
}
