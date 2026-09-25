using UnityEngine;

public class CloseMovement : MonoBehaviour
{
    #region Variables

    [SerializeField] private Transform player;

    // [SerializeField] private EnemyStats enemyStats;
    //
    // [SerializeField] private float movementSpeed;

    private float smallMoveSpeed;
    private float empoweredSmallMoveSpeed;
    private float bigMoveSpeed;
    private float empoweredBigMoveSpeed;
    private float bossMoveSpeed;
    #endregion

    private void Awake()
    {
        
    }

    private void Start()
    {
        // movementSpeed = enemyStats.movementSpeed;
    }

    private void Update()
    {
        SmallMovement();
        BigMovement();
        SmallEmpoweredMovement();
        BigEmpoweredMovement();
        BossMovement();
    }

    private void SmallMovement()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, (smallMoveSpeed * Time.deltaTime));
    }

    private void BigMovement()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, (bigMoveSpeed * Time.deltaTime));
    }

    private void SmallEmpoweredMovement()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, (empoweredSmallMoveSpeed * Time.deltaTime));
    }

    private void BigEmpoweredMovement()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, (empoweredBigMoveSpeed * Time.deltaTime));
    }

    private void BossMovement()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, (bossMoveSpeed * Time.deltaTime));
    }


}
