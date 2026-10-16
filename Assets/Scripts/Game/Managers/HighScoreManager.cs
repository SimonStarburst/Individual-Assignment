using UnityEngine;

public class HighScoreManager : MonoBehaviour
{
    #region Variables

    [SerializeField] private LevelUpManager levelUpManager;
    [SerializeField] private TimerScript timer;

    [Header("Point Variables")]
    public int enemyScore;
    public int playTime;
    public int playerLevel;
    public int totalScore;
    public int finalScore;
    public int highScore;
    public int loadedHighScore;

    #endregion

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LoadScore();
        highScore = loadedHighScore;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreTotal();
        FinalScore();
    }

    public void ScoreTotal()
    {
        totalScore = (enemyScore * 50) + (playerLevel * 1000);
    }

    public void EnemyScore(float points)
    {
        enemyScore += (int)points;
    }

    public void FinalScore()
    {
        finalScore = totalScore + (playTime * 10);
    }

    public void HighScore()
    {
        if (highScore < finalScore)
        {
            highScore = finalScore;
        }
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
        Debug.Log("High Score" + highScore);
    }

    public void LoadScore()
    {
        loadedHighScore = PlayerPrefs.GetInt("HighScore");
    }
}
