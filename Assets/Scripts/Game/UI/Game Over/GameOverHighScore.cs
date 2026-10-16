using System;
using TMPro;
using UnityEngine;

public class GameOverHighScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI highScoreText;
    [SerializeField] private HighScoreManager highScore;
    [SerializeField] private Health playerHealth;

    private void Update()
    {
        OnDefeat();
    }

    private void OnDefeat()
    {
        if (playerHealth.currentHealth <= 0)
        {
            highScore.HighScore();
            highScoreText.text = Convert.ToString("High Score:\n" + highScore.highScore);
        }
    }

}
