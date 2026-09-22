using NUnit.Framework;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Assertions;

public class LevelUpScreen : MonoBehaviour
{
    public bool lvlScreen;
    public LvlUpCard[] allLvlCards;

    public LevelUpButton lvlUpButton1;
    public LevelUpButton lvlUpButton2;
    public LevelUpButton lvlUpButton3;


    public int RandomLevelCard1;
    public int RandomLevelCard2;
    public int RandomLevelCard3;


    private void Awake()
    {
        allLvlCards = Resources.LoadAll<LvlUpCard>("LevelUpCards");
        LvlUpCardRandomizer();
    }

    private void Start()
    {
        LevelScreenInactive();
        lvlScreen = false;
    }

    private void Update()
    {        
        LvlUpCardRandomizer();
    }

    public void LevelScreenActive()
    {
        gameObject.SetActive(true);
        lvlUpButton1.lvlUpCard = allLvlCards[RandomLevelCard1];
        lvlUpButton2.lvlUpCard = allLvlCards[RandomLevelCard2];
        lvlUpButton3.lvlUpCard = allLvlCards[RandomLevelCard3];


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

        do
        {
            RandomLevelCard1 = Random.Range(0, allLvlCards.Length);
            RandomLevelCard2 = Random.Range(0, allLvlCards.Length);
            RandomLevelCard3 = Random.Range(0, allLvlCards.Length);
        }
        while (RandomLevelCard1 == RandomLevelCard2 || RandomLevelCard1 == RandomLevelCard3 || RandomLevelCard2 == RandomLevelCard3 || RandomLevelCard2 == RandomLevelCard3 || RandomLevelCard3 == RandomLevelCard1 || RandomLevelCard3 == RandomLevelCard2);

        // 2nd button is sometimes blank now, how to adjust that?    
    
    }

}
