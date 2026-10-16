using UnityEngine;

public class RangeMovement : MonoBehaviour
{
    #region Variables

    private GameObject target;

    [SerializeField] private BaseStats enemyStats;
    private float movementSpeed;

    [Header("Boleans")]
    public bool shootingRange;
    public bool fleeingRange;
    #endregion

    private void Awake()
    {
        shootingRange = false;
        fleeingRange = false;
    }

    private void Start()
    {                
        target = GameObject.FindGameObjectWithTag("Player");
        movementSpeed = enemyStats.baseSpeed;
    }

    private void Update()
    {
        MovementShoot();

    }

    private void MovementShoot()
    {
        
        if (Vector2.Distance(gameObject.transform.position, target.transform.position) >= 20f)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, (movementSpeed * Time.deltaTime));
        }

        else if (Vector2.Distance(gameObject.transform.position, target.transform.position) < 20f && Vector2.Distance(gameObject.transform.position, target.transform.position) >= 5f)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, (movementSpeed * Time.deltaTime));
            shootingRange = true;
            fleeingRange = false;
        }

        else if (Vector2.Distance(gameObject.transform.position, target.transform.position) < 5f)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, (-movementSpeed * Time.deltaTime));

            fleeingRange = true;
        }

        else
        {
            shootingRange = false;
            fleeingRange = false;
        }


    }

}
