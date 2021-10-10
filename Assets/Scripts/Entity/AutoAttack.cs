using System;
using UnityEngine;

public class AutoAttack : MonoBehaviour
{
    [SerializeField] private float _attackTime;
    private bool _timerIsGoing;

    private void OnDisable() => _timerIsGoing = false;

    public void Attack(Action action)
    {
        if (!_timerIsGoing)
        {
            _timerIsGoing = true;
            StartCoroutine(Timer.StartTimer(_attackTime, () => { action.Invoke(); _timerIsGoing = false; }));
        }
    }
}
