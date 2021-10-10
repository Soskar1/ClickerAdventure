using UnityEngine;
using TMPro;
using MainGame;
using System.Collections.Generic;

namespace Currencies.UI
{
    public class CurrencyDisplay : MonoBehaviour
    {
        [SerializeField] private GameData _data;
        private Dictionary<Currency, TextMeshProUGUI> _currencyText = new Dictionary<Currency, TextMeshProUGUI>();

        [SerializeField] private TextMeshProUGUI _amountText;

        private Currency _greenShard;

        private void Start()
        {
            _greenShard = _data.ReturnResource(CurrencyType.GreenShard);
            _currencyText.Add(_greenShard, _amountText);
            _greenShard.CurrencyReceived += Display;

            _amountText.SetText("0");
        }

        private void Display(Currency currency)
        {
            if (_currencyText.TryGetValue(currency, out TextMeshProUGUI text))
                text.SetText(currency.Quantity.ToString());
            else
                throw new System.Exception("не нахожу текст");
        }
    }
}
