using UnityEngine;

public class Enemy : Entity, IRewardable
{
    [SerializeField] private Reward _reward;
    [SerializeField] private Combat _combat;
    [SerializeField] private AutoAttack _autoAttack;
    [SerializeField] private IAmplification _amplification;

    private void Start()
    {
        _amplification = GetComponent<IAmplification>();
        _health.Killed += _amplification.Amplify;
        _health.Killed += GetReward;
    }

    private void Update()
    {
        if (_combat.Entity != null)
            _autoAttack.Attack(_combat.Hit);
    }

    public void GetReward() => _reward.Drop();
}
