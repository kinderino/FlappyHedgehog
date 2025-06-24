using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Logic : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    { 
        playerScore += 1;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
