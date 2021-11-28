using System;
using UnityEngine;

public class AutoAttack : MonoBehaviour
{
    [SerializeField] private float _attackTime;
    private bool _timerIsGoing;

    private void OnDisable() => _timerIsGoing = false;

    public void Attack(Action attackAction)
    {
        if (!_timerIsGoing)
        {
            _timerIsGoing = true;
            StartCoroutine(Timer.StartTimer(_attackTime, () => { attackAction.Invoke(); _timerIsGoing = false; }));
        }
    }
}
