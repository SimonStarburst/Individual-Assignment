using UnityEngine;

public class StatBuff : MonoBehaviour
{
    [SerializeField] private LevelUpManager levelUpManager;
    [SerializeField] private AuraScript aura;
    [SerializeField] private SwordScript sword;
    [SerializeField] private PlayerStats playerStats;
    [SerializeField] private ExpAbsorbPlayerScript expAbsorb;
    [SerializeField] private OrbScript orb;
    [SerializeField] private LaserScript laser;

    private LevelUpMenuManager levelUpMenuManager;

    private void Awake()
    {
        levelUpMenuManager = GetComponent<LevelUpMenuManager>();
    }


    public void AuraBase()
    {
        levelUpMenuManager.upgradeButtons.AddRange(levelUpMenuManager.auraUpgrades);
        levelUpMenuManager.CloseLevelUp();
    }
    public void AuraArea()
    {
        aura.transform.localScale += new Vector3(1, 1, 1);
        levelUpMenuManager.CloseLevelUp();

    }

    public void AuraDamage()
    {
        aura.damage += 1;
        levelUpMenuManager.CloseLevelUp();

    }
    public void AuraCooldown()
    {
        aura.cooldown -= 0.5f;
        levelUpMenuManager.CloseLevelUp();
    }

    public void LaserBase()
    {
        levelUpMenuManager.upgradeButtons.AddRange(levelUpMenuManager.laserUpgrades);
        levelUpMenuManager.CloseLevelUp();
    }

    public void LaserBounce()
    {
        
        levelUpMenuManager.CloseLevelUp();

    }

    public void LaserCooldown()
    {

        levelUpMenuManager.CloseLevelUp();
    }

    public void OrbBase()
    {
        levelUpMenuManager.upgradeButtons.AddRange(levelUpMenuManager.orbUpgrades);
        levelUpMenuManager.CloseLevelUp();

    }

    public void OrbArea()
    {
        levelUpMenuManager.CloseLevelUp();

    }

    public void OrbPlusOne()
    {
        levelUpMenuManager.CloseLevelUp();

    }

    public void ExpAbsorb()
    {
        expAbsorb.transform.localScale += new Vector3(1, 1, 1);
        levelUpMenuManager.CloseLevelUp();

    }

    public void MoveSpeed()
    {
        playerStats.moveStat += 1;
        levelUpMenuManager.CloseLevelUp();

    }

    public void SwordSize()
    {
        sword.transform.localScale += new Vector3(1, 1, 1);
        levelUpMenuManager.CloseLevelUp();

    }

    public void SwordDamage()
    {
        sword.damage += 1;
        levelUpMenuManager.CloseLevelUp();

    }

    public void SwordSpeed()
    {
        sword.cooldown -= 0.5f;
        levelUpMenuManager.CloseLevelUp();

    }

}
