using UnityEngine;

[RequireComponent(typeof(Reward))]
public class Chest : Entity, IRewardable
{
    [SerializeField] private Reward _reward;

    private void Start() => _health.Killed += GetReward;

    public void GetReward() => _reward.Drop();
}
