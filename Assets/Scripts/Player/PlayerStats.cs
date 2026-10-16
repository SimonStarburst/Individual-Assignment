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


    [Header("Player Stats")]

    public float maxHP;
    public float playerHP;
    public float moveStat;
    public float attackStat;

    [Header("Player Level")]
    [SerializeField] private int playerLvl;
    [SerializeField] private int totalExp;


    [SerializeField] private int swordLvl;
    [SerializeField] private int moveLvl;
    [SerializeField] private int auraLvl;
    [SerializeField] private int laserLvl;
    [SerializeField] private int orbLvl;




    #endregion


    private void Awake()
    {
        maxHP = playerStats.baseHealth;
        playerHP = maxHP;
        moveStat = playerStats.baseSpeed;
        attackStat = playerStats.baseStrength;
        swordLvl = 1;
        moveLvl = 1;
    }


}
