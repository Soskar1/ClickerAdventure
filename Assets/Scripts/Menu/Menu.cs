using MainHero;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private Hero _hero;

    public void StartGame()
    {
        gameObject.SetActive(false);
        _hero.enabled = true;
    }

    public void EnterShop()
    {
        //
    }
}
