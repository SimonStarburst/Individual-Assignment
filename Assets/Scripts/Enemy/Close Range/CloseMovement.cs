using UnityEngine;

public class CloseMovement : MonoBehaviour
{
    #region Variables

    [SerializeField] private BaseStats enemyStats;
    private GameObject target;
    private float movementSpeed;
    #endregion

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
    }
}
