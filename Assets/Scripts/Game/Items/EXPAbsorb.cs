using UnityEngine;

public class EXPAbsorb : MonoBehaviour
{
    #region Variables
    [SerializeField] private float movementSpeed;

    [SerializeField] private GameObject target;
    #endregion

    // Update is called once per frame
    void Update()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EXPAbsorb"))
        {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, (movementSpeed * Time.deltaTime));
            Debug.Log("EXP moving towards player");
        }
    }
}
