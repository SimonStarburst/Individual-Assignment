using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private BaseStats baseStat;
    [SerializeField] private EnemyManager enemyManager;
    [SerializeField] private GameOverManager gameOverManager;
    [SerializeField] private GameObject playerSprite;
    [SerializeField] private GameObject playerWeapons;
    [SerializeField] private HighScoreManager highScore;


    public float maxHealth;
    public float currentHealth;

    private void Awake()
    {
        maxHealth = baseStat.baseHealth;
    }

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Defeat();
        }
    }

    private void Defeat()
    {
        if (gameObject.CompareTag("Enemy"))
        {
            //highScore.EnemyScore(maxHealth);
            gameObject.SetActive(false);
        }
        else if (gameObject.CompareTag("Player"))
        {
            gameOverManager.GameOver();
            //gameObject.SetActive(false);
            playerSprite.SetActive(false);
            playerWeapons.SetActive(false);
            enemyManager.StopSpawning();
        }
    }
}
