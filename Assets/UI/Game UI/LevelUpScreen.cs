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

    [SerializeField] private LevelUpRandomizer levelUpRandomizer;

    #endregion

    private void Awake()
    {
        //levelUpRandomizer = GetComponent<LevelUpRandomizer>();
        //allLvlCards = Resources.LoadAll<LvlUpCard>("LevelUpCards");
    }

    private void Start()
    {
        LevelScreenInactive();
    }

    private void Update()
    {        

    }

    public void LevelScreenActive()
    {
        lvlScreen = true;
        gameObject.SetActive(true);

        LevelUpCard1();
        // lvlUpButton1 (BASE)
        //lvlUpButton1.lvlUpCard = levelUpRandomizer.baseCards[levelUpRandomizer.baseWeapon];

        // lvlUpButton2 (WEAPON UPGRADE)


        // lvlUpButton3 (PLAYER UPGRADE)
        lvlUpButton3.lvlUpCard = levelUpRandomizer.playerUpgrades[levelUpRandomizer.statUpgrades];

        Time.timeScale = 0;
    }

    public void LevelScreenInactive()
    {        
        gameObject.SetActive(false);
        Time.timeScale = 1;
        lvlScreen = false;
    }

    public void option1()
    {
        Debug.Log("Option 1 " + levelUpRandomizer.baseWeapon);
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

    private void LevelUpCard1()
    {
        lvlUpButton1.lvlUpCard.name = levelUpRandomizer.baseCards[levelUpRandomizer.baseWeapon].ToString();
    }

    private void LevelUpCard2()
    {

    }

    private void LevelUpCard3()
    {

    }

}
