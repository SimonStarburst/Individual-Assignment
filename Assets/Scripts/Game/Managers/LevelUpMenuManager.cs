using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUpMenuManager : MonoBehaviour
{
    #region Variables
    [SerializeField] GameObject panel;
    [SerializeField] private PauseManager pauseManager;
    [SerializeField] private LevelUpManager levelUpManager;

    [Header("Button Positions")]
    public Vector2 buttonPos1;
    public Vector2 buttonPos2;
    public Vector2 buttonPos3;
    public Vector2 buttonPos4;

    [Header("Lists")]
     public List<Button> buttons;
     public List<Button> upgradeButtons;
     public List<Button> auraUpgrades;
     public List<Button> laserUpgrades;
     public List<Button> orbUpgrades;

    [Header("Boleans")]
    private bool auraGet;
    private bool laserGet;
    private bool orbGet;



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
