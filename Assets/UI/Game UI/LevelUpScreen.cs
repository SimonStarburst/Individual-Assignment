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
        LevelScreenInactive();
        lvlScreen = false;
    }

    private void Update()
    {
        RandomLevelCard1 = Random.Range(0, allLvlCards.Length);
        RandomLevelCard2 = Random.Range(0, allLvlCards.Length);
        RandomLevelCard3 = Random.Range(0, allLvlCards.Length);
    }

    public void LevelScreenActive()
    {
        // Randomize the 3 lvl cards Player can pick from here?
        // It now picks the first card of the Array, since it only randomizes when Game Object is active
        // Need to be able to randomize lvl card while keeping the Game Object hidden
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
}
