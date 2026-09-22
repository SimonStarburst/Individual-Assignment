using UnityEngine;

public class LevelUpRandomizer : MonoBehaviour
{
    /*
     * --------------------------------------------------------------------------
     * First load in following from Resources into different arrays:
     *  - Base
     *  - Upgrades
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
    public LvlUpCard[] upgradeCards;


    #endregion

    private void Awake()
    {
        baseCards = Resources.LoadAll<LvlUpCard>("Base");
        upgradeCards = Resources.LoadAll<LvlUpCard>("Upgrade");


    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
