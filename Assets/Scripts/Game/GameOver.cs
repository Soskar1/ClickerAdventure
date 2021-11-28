using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainGame
{
    public class GameOver : MonoBehaviour
    {
        [SerializeField] private Health _player;

        private void Awake() => _player.Killed += RestartGame;
        private void OnDisable() => _player.Killed -= RestartGame;

        private void RestartGame() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
