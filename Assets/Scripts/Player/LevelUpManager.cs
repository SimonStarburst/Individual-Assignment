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
    //List of ALL available upgrades
    [SerializeField] private List<LvlUpCard> upgrades;

    //List of upgrades available on level up
    //Add the chosen upgrades to this list and then
    //re-add them to the upgrade list if they are stackable
    //OR remove them from the upgrade list if they are base weapons!
    [SerializeField] private List<LvlUpCard> upgradeOptions;

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

    // The required experience to level up is the current player level times 10, so it will always require more exp.
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
        if (playerEXP > LEVEL_UP)
        {

            LevelUp();
        }
    }
    // When the player levels up, the level up screen is activated, the player's EXP is subtracted by the amount
    //required to reach the previous level and the player level is increased by 1.
    private void LevelUp()
    {
        //LevelUpOptionButton1();
        //LevelUpOptionButton2();
        //LevelUpOptionButton3();
        levelUpMenu.OpenLevelUp();
        playerEXP -= LEVEL_UP;
        playerLvl += 1;
    }

    //private void LevelUpOptionButton1()
    //{
    //    random1 = Random.Range(0, upgrades.Count);

    //    upgradeOptions.Add(upgrades[random1]);

    //    upgradeButton1.Set(upgradeOptions[0]);

    //    upgrades.Remove(upgrades[random1]);
    //}

    //private void LevelUpOptionButton2()
    //{
    //    random2 = Random.Range(0, upgrades.Count);

    //    upgradeOptions.Add(upgrades[random2]);

    //    upgradeButton2.Set(upgradeOptions[1]);   
        
    //    upgrades.Remove(upgrades[random2]);
    //}

    //private void LevelUpOptionButton3()
    //{
    //    random3 = Random.Range(0, upgrades.Count);

    //    upgradeOptions.Add(upgrades[random3]);

    //    upgradeButton3.Set(upgradeOptions[2]);        
        
    //    upgrades.Remove(upgrades[random3]);
    //}

    //private void AuraBase()
    //{
    //    Debug.Log("Aura Base has been chosen!");

    //    auraGet = true;
    //    upgrades.AddRange(auraUpgrades);        
    //    // Remove AuraBase from list
    //}

    //private void LaserBase()
    //{
    //    Debug.Log("Laser Base has been chosen!");

    //    laserGet = true;
    //    upgrades.AddRange(laserUpgrades);
    //    // Remove LaserBase from list

    //}

    //private void OrbBase()
    //{
    //    Debug.Log("Orb Base has been chosen!");

    //    laserGet = true;
    //    upgrades.AddRange(orbUpgrades);
    //    // Remove OrbBase from list

    //}

}
