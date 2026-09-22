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
     *  Then randomize whether Base or Upgrade should be used first, after that 
     *  randomize contest of the chosen array.
     *  
     *  First options should only be new weapons (Base) or 
     *  movement speed (Upgrades), but as the player chooses weapons (Base) 
     *  they unlock more upgrades (Upgrades) for that specific base weapon, all 
     *  while removing the weapon (Base) from the Base Array
     * --------------------------------------------------------------------------
    */

    #region Variables

    public LvlUpCard[] baseCards;
    public LvlUpCard[] auraUpgrades;
    public LvlUpCard[] laserUpgrades;
    public LvlUpCard[] orbUpgrades;
    public LvlUpCard[] playerUpgrades;
    public LvlUpCard[] swordUpgrades;



    public bool auraEquipped;
    public bool laserEquipped;
    public bool orbEquipped;


    #endregion

    private void Awake()
    {
        baseCards = Resources.LoadAll<LvlUpCard>("Base");
        auraUpgrades = Resources.LoadAll<LvlUpCard>("AuraUpgrades");
        laserUpgrades = Resources.LoadAll<LvlUpCard>("LaserUpgrades");
        orbUpgrades = Resources.LoadAll<LvlUpCard>("OrbUpgrades");
        playerUpgrades = Resources.LoadAll<LvlUpCard>("PlayerUpgrades");
        swordUpgrades = Resources.LoadAll<LvlUpCard>("SwordUpgrades");
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
        
    }


}
