using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private BaseStats baseStat;
    [SerializeField] private EnemyManager enemyManager;

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
        if (currentHealth <= 0 && gameObject.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
        }

    }
}
