using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LevelUpManager : MonoBehaviour
{
    #region Variables
    private PlayerStats playerStats;
    public int playerLvl = 1;
    public int playerEXP = 0;
    public int toNextLevel;
    private int totalEXP = 0;

    public int random1;
    public int random2;
    public int random3;

    [SerializeField] private LevelUpMenuManager levelUpMenu;
    [SerializeField] private UpgradeButton upgradeButton1;
    [SerializeField] private UpgradeButton upgradeButton2;
    [SerializeField] private UpgradeButton upgradeButton3;

    [Header("Lists")]
    //List of available upgrades
    [SerializeField] private List<LvlUpCard> upgrades;

    [SerializeField] private List<LvlUpCard> auraUpgrades;
    [SerializeField] private List<LvlUpCard> laserUpgrades;
    [SerializeField] private List<LvlUpCard> orbUpgrades;


    [Header("Boleans")]
    bool auraGet;
    bool laserGet;
    bool orbGet;

    #endregion

    private void Awake()
    {
        playerStats = GetComponent<PlayerStats>();
        auraGet = false;
        laserGet = false;
        orbGet = false;
    }

    private void Update()
    {
        toNextLevel = playerLvl * 10;
    }

    // The required experience to level up is the current player level times 100, so it will always require more exp.
    int LEVEL_UP
    {
        get
        {
            return playerLvl * 10;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // When Player collides with Game Object with tag "EXP", they will gain 1 EXP
        if (collision.gameObject.CompareTag("EXP"))
        {
            AddExperience(1);
        }
    }

    // Whenever the player gains EXP, the amount is added to the playerEXP int and the script checks if the 
    // accrued amount of experience is enough to level up. The player's current EXP is also added to the
    // total amount of EXP earned this game.
    public void AddExperience(int amount)
    {
        playerEXP += amount;
        totalEXP += playerEXP;
        CheckLevelUp();
    }

    // If the player's EXP is equal to, or exceeds, the int LEVEL_UP, the LevelUp method is called. 
    // public void CheckLevelUp()
    public void CheckLevelUp()
    {
        if (playerEXP >= LEVEL_UP)
        {

            LevelUp();
        }
    }
    // When the player levels up, the level up screen is activated, the player's EXP is subtracted by the amount
    //required to reach the previous level and the player level is increased by 1.
    private void LevelUp()
    {
        LevelUpOptionButton1();
        LevelUpOptionButton2();
        LevelUpOptionButton3();
        levelUpMenu.OpenLevelUp();
        playerEXP -= LEVEL_UP;
        playerLvl += 1;
    }

    private void LevelUpOptionButton1()
    {
        random1 = Random.Range(0, upgrades.Count);
        upgradeButton1.Set(upgrades[random1]);

        if (upgradeButton1.nameText.text == "AuraBase")
        {
            AuraBase();
        }

        else if (upgradeButton1.nameText.text == "LaserBase")
        {
            LaserBase();
        }
        else if (upgradeButton1.nameText.text == "OrbBase")
        {
            OrbBase();
        }

    }

    private void LevelUpOptionButton2()
    {
        random2 = Random.Range(0, upgrades.Count);
        upgradeButton2.Set(upgrades[random2]);
        if (upgradeButton1.nameText.text == "AuraBase")
        {
            AuraBase();
        }

        else if (upgradeButton1.nameText.text == "LaserBase")
        {
            LaserBase();
        }
        else if (upgradeButton1.nameText.text == "OrbBase")
        {
            OrbBase();
        }
    }

    private void LevelUpOptionButton3()
    {
        random3 = Random.Range(0, upgrades.Count);
        upgradeButton3.Set(upgrades[random3]);
        if (upgradeButton1.nameText.text == "AuraBase")
        {
            AuraBase();
        }

        else if (upgradeButton1.nameText.text == "LaserBase")
        {
            LaserBase();
        }
        else if (upgradeButton1.nameText.text == "OrbBase")
        {
            OrbBase();
        }
    }

    private void AuraBase()
    {
        Debug.Log("Aura Base has been chosen!");

        // Remove AuraBase from list
        auraGet = true;
        upgrades.AddRange(auraUpgrades);
    }

    private void LaserBase()
    {
        Debug.Log("Laser Base has been chosen!");


        // Remove LaserBase from list
        laserGet = true;
        upgrades.AddRange(laserUpgrades);

    }

    private void OrbBase()
    {
        Debug.Log("Orb Base has been chosen!");


        // Remove OrbBase from list
        laserGet = true;
        upgrades.AddRange(orbUpgrades);

    }

}
