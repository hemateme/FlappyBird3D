using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{   
    // [Header("References")]
    [SerializeField] private GameObject startMenu;
    // [SerializeField] private GameObject gameOverMenu;
    private enum GameState
    {
        Paused,
        Playing,
        GameOver
    }
    
    private GameState _gameState = GameState.Paused;
    
    public void OnGameStart()
    {
        startMenu.SetActive(false);
        _gameState = GameState.Playing;
        
    }

    public void PauseGame()
    {
        _gameState = GameState.Paused;
    }
}
