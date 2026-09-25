using UnityEngine;

public class CloseMovement : MonoBehaviour
{
    #region Variables

    [SerializeField] private Transform player;

    [SerializeField] private EnemyBaseStats enemyStats;
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
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, (movementSpeed * Time.deltaTime));
    }

}
