using UnityEngine;

public class AuraScript : MonoBehaviour
{
    #region Variables

    public Animator animator;
    private bool isAttacking;

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
        isEquipped = false;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        abilityTimer -= Time.deltaTime;
        TimeReset();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && abilityTimer <= 0)
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

    private void TimeReset()
    {
        if (abilityTimer < -0.1)
        {
            abilityTimer = cooldown;
        }
    }
}
