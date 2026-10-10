using System.Collections.Generic;
using UnityEngine;

public class LevelUpManager : MonoBehaviour
{
    private int playerLvl = 1;
    private int playerEXP = 0;
    private int totalEXP = 0;

    [SerializeField] private LevelUpMenuManager levelUpMenu;
    [SerializeField] private UpgradeButton upgradeButton1;
    [SerializeField] private UpgradeButton upgradeButton2;
    [SerializeField] private UpgradeButton upgradeButton3;


    //Pool of available upgrades
    [SerializeField] private List<LvlUpCard> upgrades;


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
        upgradeButton1.Set(upgrades[Random.Range(0, upgrades.Count)]);
    }

    private void LevelUpOptionButton2()
    {
        upgradeButton2.Set(upgrades[Random.Range(0, upgrades.Count)]);

    }

    private void LevelUpOptionButton3()
    {
        upgradeButton3.Set(upgrades[Random.Range(0, upgrades.Count)]);

    }
}
