using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private HighScoreManager highScore;


    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE: " + highScore.totalScore.ToString();
    }
}
