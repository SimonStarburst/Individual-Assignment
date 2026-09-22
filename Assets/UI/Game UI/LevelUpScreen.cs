using NUnit.Framework;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Assertions;

public class LevelUpScreen : MonoBehaviour
{
    #region    Variables
    public bool lvlScreen;
    public LvlUpCard[] allLvlCards;

    public LevelUpButton lvlUpButton1;
    public LevelUpButton lvlUpButton2;
    public LevelUpButton lvlUpButton3;

    private LevelUpRandomizer levelUpRandomizer;

    #endregion

    private void Awake()
    {
        levelUpRandomizer = GetComponent<LevelUpRandomizer>();
        // allLvlCards = Resources.LoadAll<LvlUpCard>("LevelUpCards");
    }

    private void Start()
    {
        lvlUpButton1.lvlUpCard = levelUpRandomizer.baseCards[levelUpRandomizer.baseWeapon];

        lvlUpButton3.lvlUpCard = levelUpRandomizer.playerUpgrades[levelUpRandomizer.statUpgrades];

        LevelScreenInactive();
        lvlScreen = false;
    }

    private void Update()
    {        

    }

    public void LevelScreenActive()
    {
        gameObject.SetActive(true);

        // lvlUpButton1 (BASE)
        lvlUpButton1.lvlUpCard = levelUpRandomizer.baseCards[levelUpRandomizer.baseWeapon];

        // lvlUpButton2 (WEAPON UPGRADE)

        // lvlUpButton3 (PLAYER UPGRADE)
        lvlUpButton3.lvlUpCard = levelUpRandomizer.playerUpgrades[levelUpRandomizer.statUpgrades];

        Time.timeScale = 0;
    }

    public void LevelScreenInactive()
    {        
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void option1()
    {
        Debug.Log("Option 1");
        LevelScreenInactive();

    }
    public void option2()
    {
        Debug.Log("Option 2");
        LevelScreenInactive();
    }
    public void option3()
    {
        Debug.Log("Option 3");
        LevelScreenInactive();
    }

    private void LvlUpCardRandomizer()
    {
        // Randomize a member of the array between 0 and the length of array
        // Do while to see if the number is the same, to randomize until they're different


        // 2nd button is sometimes blank now, how to adjust that?    
    
    }

}
