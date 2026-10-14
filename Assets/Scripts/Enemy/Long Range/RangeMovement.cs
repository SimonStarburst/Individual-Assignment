using UnityEngine;

public class RangeMovement : MonoBehaviour
{
    #region Variables

    private GameObject target;

    [SerializeField] private BaseStats enemyStats;
    private float movementSpeed;
    #endregion

    private void Awake()
    {

    }

    private void Start()
    {
        movementSpeed = enemyStats.baseSpeed;
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, (movementSpeed * Time.deltaTime));
        if (Vector2.Distance(gameObject.transform.position, target.transform.position) < 10f)
        {
            Debug.Log("Enemy shoots!");
        }

    }

}
