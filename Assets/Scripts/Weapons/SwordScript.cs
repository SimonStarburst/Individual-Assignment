using Unity.VisualScripting;
using UnityEngine;

public class SwordScript : MonoBehaviour
{
    #region Variables

    [SerializeField] private PlayerMovement playerMovement;
    public Animator animator;
    private CapsuleCollider2D capsuleCollider;
    private bool isAttacking;

    private Vector3 left = new Vector3 (-0.3f ,0f);
    private Vector3 right = new Vector3 (0.3f, 0f);

    [Header("Sword Stats")]
    public float abilityTimer;

    // Affects how often the sword attacks
    public float cooldown;

    // Affects the damage of the sword
    public float damage;

    // Will affect size of sword
    public float size;

    #endregion

    private void Awake()
    {
        isAttacking = false;
        capsuleCollider = GetComponent<CapsuleCollider2D>();
    }

    void Update()
    {
        abilityTimer -= Time.deltaTime;
        Direction();
        Attack();
    }

    public void Attack()
    {
        if (abilityTimer <= 0)
        {
            isAttacking = true;
            animator.SetBool("isAttacking", true);
            abilityTimer = cooldown;
            Debug.Log("Swing sword!");
        }
    }

    public void StopAttack()
    {
        isAttacking = false;
        animator.SetBool("isAttacking", false);
    }

    //public void DealDamage()
    //{
    //    Collider2D[] enemies = Physics2D.OverlapCapsuleAll(capsuleCollider.transform.position, enemyLayer);
    //    if (enemies.Length > 0)
    //    {
    //        enemies[0].GetComponent<Health>().TakeDamage(damage);
    //    }
    //}

    public void Direction()
    {
        if (playerMovement.right)
        {
            gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 180f);
            gameObject.transform.position = playerMovement.transform.position + right;
        }

        else if (playerMovement.left)
        {
            gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            gameObject.transform.position = playerMovement.transform.position + left;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && isAttacking)
        {
            Health enemyHealth = collision.GetComponent<Health>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damage);
                Debug.Log("Enemy is taking " + damage + " damage");
            }
            abilityTimer = cooldown;
        }
    }
}
