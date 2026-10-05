using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private BaseStats baseStat;

    public float maxHealth;
    public float currentHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        maxHealth = baseStat.baseHealth;
    }

    void Start()
    {
        currentHealth = maxHealth;
    }

    void TakeDamage(int amount)
    {
        currentHealth -= amount;
    }

}
