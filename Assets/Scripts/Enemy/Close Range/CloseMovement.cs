using UnityEngine;

public class CloseMovement : MonoBehaviour
{
    public Transform player;
    public float smallMoveSpeed;
    public float empoweredSmallMoveSpeed;
    public float bigMoveSpeed;
    public float empoweredBigMoveSpeed;
    public float bossMoveSpeed;

    private void Awake()
    {
        
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        EnemyCloseMovement();
    }

    private void EnemyCloseMovement()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, (smallMoveSpeed * Time.deltaTime));
    }


}
