using UnityEngine;

public class CloseAttack : MonoBehaviour
{
    [SerializeField] private BaseStats attackStat;
    private float damage;
    public float damageInterval = 1f;
    public float attackTimer = 0f;

    private void Awake()
    {
        damage = attackStat.baseStrength;
    }

    // Update is called once per frame
    void Update()
    {
        attackTimer += Time.deltaTime;
    }

    // If the enemy collides with something that has the "Player" tag, it should deal damage equal to the amount that is saved in the
    // enemy's base stat SO 

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player" && attackTimer >= damageInterval)
        {
            //var healthComponent = collision.GetComponent<Health>();
            Health playerHealth = collision.GetComponent<Health>();
            if (playerHealth != null)
            {
                Debug.Log("Player takes " + damage + " damage!");
                playerHealth.TakeDamage(damage);
            }
            attackTimer = 0f;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            attackTimer = 0f;
        }
    }
}
