using UnityEngine;

public class BulletScript : MonoBehaviour
{
    #region Variables
    [SerializeField] private float damage;
    [SerializeField] private float bulletSpeed;
    GameObject target;
    Vector2 targetPosition;

    #endregion
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        targetPosition = target.transform.position;
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, (bulletSpeed * Time.deltaTime));
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
