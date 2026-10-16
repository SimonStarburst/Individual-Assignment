using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpMenuManager : MonoBehaviour
{
    #region Variables
    [SerializeField] GameObject panel;
    [SerializeField] private PauseManager pauseManager;
    [SerializeField] private LevelUpManager levelUpManager;

    [SerializeField] List<UpgradeButton> upgradeButtons;
    [SerializeField] List<UpgradeButton> currentActiveButtons;

    #endregion

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

    public void Upgrade()
    {
        CloseLevelUp();
    }

    public void CloseLevelUp()
    {
        pauseManager.UnpauseGame();
        panel.SetActive(false);
    }



}
