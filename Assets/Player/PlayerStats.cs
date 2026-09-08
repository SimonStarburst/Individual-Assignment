using UnityEngine;

public class PlayerStats : MonoBehaviour

{

    public PlayerMovement movementStats;
    public PlayerAttack attackStats;


    private void Awake()
    {
        // I will be able to adjust variables in the movement and attack scripts, for level up purposes. 
        movementStats = GetComponent<PlayerMovement>();
        attackStats = GetComponent<PlayerAttack>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
