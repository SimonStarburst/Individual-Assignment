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

    public void OpenLevelUp()
    {        
        pauseManager.PauseGame();
        panel.SetActive(true);

    }

    public void Upgrade(int pressedButton)
    {
        CloseLevelUp();
    }

    public void CloseLevelUp()
    {
        pauseManager.UnpauseGame();
        panel.SetActive(false);
    }



}
