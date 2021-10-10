using UnityEngine;
using Currencies;
using MainGame;

public class Collectible : MonoBehaviour, IPooledObject, ICollectible
{
    [SerializeField] private GameData _data;
    [SerializeField] private CurrencyType _currencyType;
    [SerializeField] private ObjectPooler.ObjectInfo.ObjectType _poolType;
    private Currency _currency;

    public ObjectPooler.ObjectInfo.ObjectType Type => _poolType;

    private void Start() => _currency = _data.ReturnResource(_currencyType);

    public void Collect()
    {
        _currency.Quantity++;
        ObjectPooler.Instance.DestroyObject(gameObject);
    }
}
