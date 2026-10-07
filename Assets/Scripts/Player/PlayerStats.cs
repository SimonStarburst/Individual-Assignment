using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour

{
    #region Variables

    [SerializeField] private BaseStats playerStats;
    public PlayerMovement moveScript;
    public PlayerAttack attackScript;
    public Health playerHealth;
    public LevelUpScreen levelUpScreen;


    [Header("Player Stats")]

    public float maxHP;
    public float playerHP;
    public float moveStat;
    public float attackStat;

    [Header("Player Level")]
    [SerializeField] private int playerLvl;
    [SerializeField] private int totalExp;

    private bool lvlUp;
    #endregion


    private void Awake()
    {
        maxHP = playerStats.baseHealth;
        playerHP = maxHP;
        moveStat = playerStats.baseSpeed;
        attackStat = playerStats.baseStrength;

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
}
