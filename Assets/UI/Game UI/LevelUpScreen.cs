using NUnit.Framework;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Assertions;

public class LevelUpScreen : MonoBehaviour
{
    public bool lvlScreen;
    public LvlUpCard[] allLvlCards;
    public int RandomLevelCard;


    private void Awake()
    {
        allLvlCards = Resources.LoadAll<LvlUpCard>("LevelUpCards");
        RandomLevelCard = Random.Range(0, allLvlCards.Length);
        LevelScreenInactive();
        lvlScreen = false;
        Debug.Log(RandomLevelCard);
    }

    public void LevelScreenActive()
    {
        gameObject.SetActive(true);
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
