using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LevelUpRandomizer : MonoBehaviour
{
    /*
     * --------------------------------------------------------------------------
     * First load in following from Resources into different arrays:
     *  - Base
     *  - AuraUpgrades
     *  - OrbUpgrades
     *  - PlayerUpgrades
     *  - SwordUpgrades
     *  
     *  Create a List<> for upgrades that add Arrays to it based on what base weapon is being used.
     *  Starts with only swordUpgrades but as soon as ie the base card for Aura is chosen, the resources
     *  from the auraUpgrades Array are added to the upgrades list, thusly being added to the pool of randomized upgrades being posted
     * --------------------------------------------------------------------------
    */

    #region Variables

    public LvlUpCard[] baseCards;
    public LvlUpCard[] auraUpgrades;
    public LvlUpCard[] laserUpgrades;
    public LvlUpCard[] orbUpgrades;
    public LvlUpCard[] playerUpgrades;
    public LvlUpCard[] swordUpgrades;

    public List<LvlUpCard> upgradeList;

    [SerializeField] private LevelUpScreen levelUpScreen;

    public bool auraEquipped;
    public bool laserEquipped;
    public bool orbEquipped;

    public int baseWeapon;
    public int weaponUpgrades;
    public int statUpgrades;


    #endregion

    private void Awake()
    {
        baseCards = Resources.LoadAll<LvlUpCard>("Base");
        auraUpgrades = Resources.LoadAll<LvlUpCard>("AuraUpgrades");
        laserUpgrades = Resources.LoadAll<LvlUpCard>("LaserUpgrades");
        orbUpgrades = Resources.LoadAll<LvlUpCard>("OrbUpgrades");
        playerUpgrades = Resources.LoadAll<LvlUpCard>("PlayerUpgrades");
        swordUpgrades = Resources.LoadAll<LvlUpCard>("SwordUpgrades");
        upgradeList = swordUpgrades.ToList();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        auraEquipped = false;
        laserEquipped = false;
        orbEquipped = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!levelUpScreen.lvlScreen)
        {        
            BaseRandomiser();
            WeaponUpgradeRandomiser();
            PlayerUpgradeRandomiser();
        }
    }

    public void BaseRandomiser()
    {
        baseWeapon = Random.Range(0, baseCards.Length);
    }

    public void WeaponUpgradeRandomiser()
    {
        weaponUpgrades = Random.Range(0, upgradeList.Count);
    }

    public void PlayerUpgradeRandomiser()
    {
        statUpgrades = Random.Range(0, playerUpgrades.Length);
    }


    

}
