using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerStats : MonoBehaviour

{
    public PlayerMovement moveScript;
    public PlayerAttack attackScript;
    public PlayerHealth healthScript;
    public LevelUpScreen levelUpScreen;


    [Header("Player Stats")]

    [SerializeField] private int maxHP;
    [SerializeField] private int playerHP;
    [SerializeField] private int moveStat;
    [SerializeField] private int attackStat;

    [Header("Player Level")]
    [SerializeField] private int playerLvl;
    [SerializeField] private int totalExp;

    private bool lvlUp;


    private void Awake()
    {
        lvlUp = levelUpScreen.lvlScreen;
        playerLvl = 1;
        maxHP = healthScript.maxHP;
        playerHP = maxHP;
        totalExp = 0;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        maxHP = healthScript.maxHP;
        LevelUp();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EXP"))
        {
            totalExp += 1;
            Debug.Log($"Total experience: {totalExp}");
        }
    }

    private void LevelUp()
    {
        if (totalExp == 10 && playerLvl == 1)
        {
            levelUpScreen.LevelScreenActive();
            Debug.Log("Level 2!");
            playerLvl += 1;
        }

        else if (totalExp == 25 && playerLvl == 2)
        {
            levelUpScreen.LevelScreenActive();
            Debug.Log("Level 3!");
            playerLvl += 1;
        }

    }
}
