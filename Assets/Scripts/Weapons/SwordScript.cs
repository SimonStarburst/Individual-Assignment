using Unity.VisualScripting;
using UnityEngine;

public class SwordScript : MonoBehaviour
{
    #region Variables

    [SerializeField] private PlayerMovement playerMovement;


    private Vector3 left = new Vector3 (-0.3f ,0f);
    private Vector3 right = new Vector3 (0.3f, 0f);

    [Header("Sword Stats")]
    public float abilityTimer;

    // Affects how often the sword attacks
    public float cooldown;

    // Affects the damage of the sword
    public float damage;

    // Will affect size of sword
    public float size;

    #endregion

    void Update()
    {
        abilityTimer -= Time.deltaTime;
        Direction();
        CastAbility();
    }

    public void CastAbility()
    {
        if (abilityTimer > 0)
        {
            return;
        }
        abilityTimer = cooldown;
        Debug.Log("Swing sword!");
    }

    public void Direction()
    {
        if (playerMovement.right)
        {
            gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 180f);
            gameObject.transform.position = playerMovement.transform.position + right;
        }

        else if (playerMovement.left)
        {
            gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            gameObject.transform.position = playerMovement.transform.position + left;
        }
    }
}
