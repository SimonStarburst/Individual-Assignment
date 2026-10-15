using UnityEngine;

public class BulletScript : MonoBehaviour
{
    #region Variables
    [SerializeField] private float damage;
    [SerializeField] private float bulletSpeed;
    private GameObject target;
    private Vector2 targetDirection;
    private Vector2 targetPosition;

    private Rigidbody2D rb;
    #endregion
    void Awake()
    {        
        target = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
        gameObject.SetActive(false);
    }

    private void OnEnable()
    {                
        targetDirection = target.transform.position - transform.position;
    }

    void Update()
    {   
        // Bullet moves faster depending on Player distance - bad, FIX!     
        rb.linearVelocity = targetDirection.normalized * bulletSpeed;  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Health playerHealth = collision.GetComponent<Health>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
                gameObject.SetActive(false);
            }
        }
        else if (collision.gameObject.CompareTag("Wall"))
        {
            gameObject.SetActive(false);
        }
    }
}
