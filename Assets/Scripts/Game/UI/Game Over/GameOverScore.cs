using System;
using TMPro;
using UnityEngine;

public class GameOverScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
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
            scoreText.text = Convert.ToString("Score:\n" + highScore.finalScore);
        }
    }

}

