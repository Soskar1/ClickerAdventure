using UnityEngine;
using System;
using MainGame.UI;

[RequireComponent(typeof(Health))]
[RequireComponent(typeof(CombatUI))]
public class Entity : MonoBehaviour, IPooledObject, IHittable
{
    public EntityData data;
    [SerializeField] protected Health _health;
    [SerializeField] private CombatUI _combatUI;

    public ObjectPooler.ObjectInfo.ObjectType Type => _poolType;
    [SerializeField] private ObjectPooler.ObjectInfo.ObjectType _poolType;

    private void Awake()
    {
        string name = Enum.GetName(typeof(ObjectPooler.ObjectInfo.ObjectType), _poolType);
        data = new EntityData(name, _health.MaxHealth);
        _combatUI.DisplayEntityData(data);
    }

    public void Hit(float damage) => _health.ReceiveDamage(damage);
}
