using Unity.VisualScripting;
using UnityEngine;

public class SwordScript : MonoBehaviour
{

    [SerializeField] private PlayerMovement playerMovement;
    public float cooldown;

    public float abilityTimer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        abilityTimer -= Time.deltaTime;
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
}
