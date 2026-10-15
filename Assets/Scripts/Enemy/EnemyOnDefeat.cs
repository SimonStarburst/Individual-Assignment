using UnityEngine;

public class EnemyOnDefeat : MonoBehaviour
{

    #region Variables

    private BaseStats enemyStats;
    private Health enemyHealth;

    public GameObject expSpawnObject;
    public EXPDropManager expSpawner;
    public GameObject highScoreObject;
    public HighScoreManager highScore;


    #endregion

    void Awake()
    {
        enemyHealth = GetComponent<Health>();
        expSpawnObject = GameObject.FindGameObjectWithTag("EXPSpawner");
        expSpawner = expSpawnObject.GetComponentInChildren<EXPDropManager>();
        highScoreObject = GameObject.FindGameObjectWithTag("Managers");
        highScore = highScoreObject.GetComponentInChildren<HighScoreManager>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void EXPDrop(Vector2 spawnPosition)
    {
        expSpawner.SpawnEXP(spawnPosition);
    }

    public void Score(float points)
    {
        highScore.EnemyScore(points);
    }
}
