using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AuraScript : MonoBehaviour
{
    #region Variables

    public Animator animator;
    private bool isAttacking;

    private List<Collider2D> enemies;

    [Header("Aura Stats")]
    public bool isEquipped;

    public float abilityTimer;

    // Affects how often the aura damage over time ticks occurs
    public float cooldown;

    // Affects the damage of the ura damage over time ticks
    public float damage;

    // Will affect size of aura
    public float size;

    #endregion

    private void Awake()
    {
        enemies = new List<Collider2D>();
        isEquipped = false;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        abilityTimer -= Time.deltaTime;
        TimeReset();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            enemies.Add(collision);
        }
    }



    private void OnTriggerStay2D(Collider2D collisions)
    {
        if (collisions.gameObject.CompareTag("Enemy") && abilityTimer <= 0)
        {
            foreach (Collider2D collision in enemies)
            {
                Health enemyHealth = collision.GetComponent<Health>();
                if (enemyHealth != null)
                {
                    enemyHealth.TakeDamage(damage);
                    Debug.Log("Enemy is taking " + damage + " Aura damage");
                }
                abilityTimer = cooldown;
            }


        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            enemies.Remove(collision);
        }
    }

    private void TimeReset()
    {
        if (abilityTimer < -0.1)
        {
            abilityTimer = cooldown;
        }
    }
}
