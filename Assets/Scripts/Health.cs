using UnityEngine;

public class Health : MonoBehaviour
{

    public int maxHealth;
    public int currentHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
    }

    void TakeDamage(int amount)
    {
        currentHealth -= amount;
    }

}
