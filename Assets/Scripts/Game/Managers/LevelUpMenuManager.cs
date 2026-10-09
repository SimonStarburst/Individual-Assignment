using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpMenuManager : MonoBehaviour
{
    [SerializeField] GameObject panel;
    PauseManager pauseManager;

    [SerializeField] List<UpgradeButton> upgradeButtons;

    private void Awake()
    {
        pauseManager = GetComponent<PauseManager>();
        panel.SetActive(false);
    }

    public void OpenLevelUp(List<LvlUpCard> lvlUpData)
    {        
        pauseManager.PauseGame();
        panel.SetActive(true);
        for (int i = 0; i < upgradeButtons.Count; i++)
        {
            upgradeButtons[i].Set(lvlUpData[i]);
        }
    }

    public void Upgrade(int pressedButton)
    {
        
        Debug.Log("Player pressed :" + pressedButton.ToString());
        CloseLevelUp();
    }

    public void CloseLevelUp()
    {
        pauseManager.UnpauseGame();
        panel.SetActive(false);
    }



}
