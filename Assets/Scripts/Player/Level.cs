//using NUnit.Framework;
//using System.Collections.Generic;
//using UnityEngine;

//public class Level : MonoBehaviour
//{
   
//    private int playerLvl = 1;
//    private int playerEXP = 0;
//    private int totalEXP = 0;

//    //[SerializeField] ExperienceBar experienceBar;
//    [SerializeField] private LevelUpScreen levelUpScreen;

//    [SerializeField] private LevelUpMenuManager levelUpMenu;

//    //Pool of available upgrades
//    [SerializeField] private List<LvlUpCard> upgrades;
//    public List<LvlUpCard> selectedUpgrades;
//    [SerializeField] private List<LvlUpCard> acquiredUpgrades;

//    // The required experience to level up is the current player level times 100, so it will always require more exp.
//    int LEVEL_UP
//    {
//        get
//        {
//            return playerLvl * 10;
//        }
//    }

//    void Start()
//    {
        
//    }

//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        // When Player collides with Game Object with tag "EXP", they will gain 1 EXP
//        if (collision.gameObject.CompareTag("EXP"))
//        {
//            AddExperience(1);
//        }
//    }

//    // Whenever the player gains EXP, the amount is added to the playerEXP int and the script checks if the 
//    // accrued amount of experience is enough to level up. The player's current EXP is also added to the
//    // total amount of EXP earned this game.

//    public void AddExperience(int amount)
//    {
//        playerEXP += amount;
//        totalEXP += playerEXP;
//        CheckLevelUp();
//    }

//    public void Upgrade(int selectedUpgrade)
//    {
//        LvlUpCard lvlUpCard = selectedUpgrades[selectedUpgrade];

//        if (acquiredUpgrades == null) { acquiredUpgrades = new List<LvlUpCard>(); }

//        acquiredUpgrades.Add(lvlUpCard);
//        upgrades.Remove(lvlUpCard);
//    }

//    // If the player's EXP is equal to, or exceeds, the int LEVEL_UP, the LevelUp method is called. 
//    public void CheckLevelUp()
//    {
//        if (playerEXP >= LEVEL_UP)
//        {

//            LevelUp();
//        }
//    }

//    // When the player levels up, the level up screen is activated, the player's EXP is subtracted by the amount
//    // required to reach the previous level and the player level is increased by 1.
//    private void LevelUp()
//    {
//        if (selectedUpgrades == null) { selectedUpgrades = new List<LvlUpCard>(); }
//        selectedUpgrades.Clear();
//        selectedUpgrades.AddRange(GetUpgrades(3));

//        levelUpMenu.OpenLevelUp(selectedUpgrades);
//        playerEXP -= LEVEL_UP;
//        playerLvl += 1;
//    }


//    // This method will return a list of upgrades that we can post as upgrade options when the Player levels up. 
//    public List<LvlUpCard> GetUpgrades(int count)
//    {
//        List<LvlUpCard> upgradeList = new List<LvlUpCard>();

//        // If there's less available upgrades then the amount called upon, change the amount called upon to match
//        // the remaining upgrades in the list.
//        if (count > upgrades.Count)
//        {
//            count = upgrades.Count;
//        }
        
//        // For each amount of objects called upon for the upgrades, add a random upgrade to the list.
//        // For example, if giving player 3 options, then this will loop through list and take 3 random upgrades.
//        for (int i = 0; i < count; i++)
//        {        
//            upgradeList.Add(upgrades[Random.Range(0, upgrades.Count)]);
//        }

//        return upgradeList;
//    }

//}
