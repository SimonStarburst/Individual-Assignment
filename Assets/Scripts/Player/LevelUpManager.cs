using System.Collections.Generic;
using UnityEngine;

public class LevelUpManager : MonoBehaviour
{
    private int playerLvl = 1;
    private int playerEXP = 0;
    private int totalEXP = 0;

    [SerializeField] private LevelUpMenuManager levelUpMenu;

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
        levelUpMenu.OpenLevelUp();
        playerEXP -= LEVEL_UP;
        playerLvl += 1;
    }
}
