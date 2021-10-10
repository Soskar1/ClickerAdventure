using System.Collections.Generic;
using UnityEngine;
using Currencies;
using System;

namespace MainGame
{
    public class GameData : MonoBehaviour
    {
        private Dictionary<CurrencyType, Currency> _currencies = new Dictionary<CurrencyType, Currency>();

        private void Awake()
        {
            int currencyTypeNumber = Enum.GetNames(typeof(CurrencyType)).Length;

            for (int index = 0; index < currencyTypeNumber; index++)
            {
                CurrencyType resourceType = (CurrencyType)index;
                Currency resource = new Currency(resourceType);
                _currencies.Add(resourceType, resource);
            }
        }

        public Currency ReturnResource(CurrencyType resourceType)
        {
            if (_currencies.TryGetValue(resourceType, out Currency resource))
                return resource;
            else
                throw new Exception("Не могу найти ресурс!");
        }
    }
}
