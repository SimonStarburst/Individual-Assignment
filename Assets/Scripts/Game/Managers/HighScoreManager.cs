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

    #endregion

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreTotal();
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
}
