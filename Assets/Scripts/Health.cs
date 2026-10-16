using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    #region Variables
    public BaseStats baseStat;
    public EnemyManager enemyManager;
    public GameOverManager gameOverManager;
    public HighScoreManager highScoreManager;
    public GameObject playerSprite;
    public GameObject playerWeapons;
    public EnemyOnDefeat enemyDefeat;

    public float maxHealth;
    public float currentHealth;
    #endregion

    private void Awake()
    {
        enemyDefeat = GetComponent<EnemyOnDefeat>();
        maxHealth = baseStat.baseHealth;
    }

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0 && gameObject.CompareTag("Enemy"))
        {                    
            enemyDefeat.EXPDrop(gameObject.transform.position);
            enemyDefeat.Score(maxHealth);
            DefeatEnemy();
        }
        if (currentHealth <= 0 && gameObject.CompareTag("Player"))
        {
            DefeatPlayer();
        }
    }

    private void DefeatEnemy()
    {

        gameObject.SetActive(false);
    }

    private void DefeatPlayer()
    {
        highScoreManager.HighScore();

        gameOverManager.GameOver();
        playerSprite.SetActive(false);
        playerWeapons.SetActive(false);
        enemyManager.StopSpawning();        
        highScoreManager.SaveScore();
    }
}
