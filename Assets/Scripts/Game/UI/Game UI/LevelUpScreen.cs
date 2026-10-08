using NUnit.Framework;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Assertions;

public class LevelUpScreen : MonoBehaviour
{
    #region    Variables

    //public LvlUpCard[] allLvlCards;

    [SerializeField]List<LevelUpButton> levelUpButtons;



    #endregion

    private void Awake()
    {

    }

    private void Start()
    {
        LevelScreenInactive();
    }

    private void Update()
    {        

    }

    public void LevelScreenActive(List<LvlUpCard> lvlUpCards)
    {        
        Time.timeScale = 0;
        gameObject.SetActive(true);
        for (int i = 0; i < lvlUpCards.Count; i++)
        {
            levelUpButtons[i].Set(lvlUpCards[i]);
        }
    }

    public void Upgrade(int pressedButton)
    {
        Debug.Log("Player pressed :" + pressedButton.ToString());
        LevelScreenInactive();
    }

    public void LevelScreenInactive()
    {                
        Time.timeScale = 1;
        gameObject.SetActive(false);
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

    private void LevelUpCard1()
    {
    }

    private void LevelUpCard2()
    {

    }

    private void LevelUpCard3()
    {

    }

}
