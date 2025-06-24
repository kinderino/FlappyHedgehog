using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Logic : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    { 
        playerScore += 1;
        scoreText.text = playerScore.ToString();
    }
}
