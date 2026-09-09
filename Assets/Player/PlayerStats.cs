using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerStats : MonoBehaviour

{
    public PlayerMovement moveScript;
    public PlayerAttack attackScript;
    public PlayerHealth healthScript;

    [Header("Player Stats")]

    [SerializeField] private int maxHP;
    [SerializeField] private int playerHP;
    [SerializeField] private int totalExp;
    [SerializeField] private int moveStat;
    [SerializeField] private int attackStat;


    private void Awake()
    {
        maxHP = healthScript.maxHP;
        playerHP = maxHP;
        totalExp = 0;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EXP"))
        {
            totalExp += 1;
            Debug.Log($"Total experience: {totalExp}");
        }
    }
}
