using UnityEngine;

public class CloseMovement : MonoBehaviour
{
    #region Variables

    public Transform player;
    public float smallMoveSpeed;
    public float empoweredSmallMoveSpeed;
    public float bigMoveSpeed;
    public float empoweredBigMoveSpeed;
    public float bossMoveSpeed;
    #endregion

    private void Awake()
    {
        
    }

    private void Start()
    {
        
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
