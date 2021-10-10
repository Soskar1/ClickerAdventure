using System;

namespace Currencies
{
    public class Currency
    {
        private int _quantity;
        private CurrencyType _currencyType;

        public Action<Currency> CurrencyReceived;

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                CurrencyReceived?.Invoke(this);
            }
        }
        public CurrencyType CurrencyType { get => _currencyType; }

        public Currency(CurrencyType currencyType)
        {
            _quantity = 0;
            _currencyType = currencyType;
        }

        public void Add(int amount)
        {
            if (amount > 0)
                Quantity += amount;
            else
                throw new Exception("Ќевозможно добавить отрицательное число!");
        }
        public void Reduce(int amount)
        {
            if (amount > 0)
                Quantity -= amount;
            else
                throw new Exception("Ќевозможно вычесть отрицательное число!");
        }
    }

    public enum CurrencyType
    {
        GreenShard
    }
}
