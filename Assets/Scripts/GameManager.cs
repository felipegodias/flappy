using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool isGameStarted;
    private bool isGameOver;
    public GameOver gameOver;

    private int points;

    public void Reload()
    {
        SceneManager.LoadScene("Game");
    }

    public bool IsGameStarted()
    {
        return isGameStarted;
    }

    public void StartGame()
    {
        isGameStarted = true;
    }

    public bool IsGameOver()
    {
        return isGameOver;
    }

    public void GameOver()
    {
        if (isGameOver)
        {
            return;
        }

        isGameOver = true;
        Instantiate(gameOver);
    }

    public int GetPoints()
    {
        return points;
    }

    public void IncreasePoint()
    {
        ++points;
    }
}