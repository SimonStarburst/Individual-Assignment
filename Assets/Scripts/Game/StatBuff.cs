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
    }
    public void AuraArea()
    {
        aura.transform.localScale += new Vector3(1, 1, 1);
    }

    public void AuraDamage()
    {
        aura.damage += 1;
    }
    public void AuraCooldown()
    {
        aura.cooldown -= 0.5f;

    }

    public void LaserBase()
    {
        levelUpMenuManager.upgradeButtons.AddRange(levelUpMenuManager.laserUpgrades);

    }

    public void LaserBounce()
    {

    }

    public void LaserCooldown()
    {

    }

    public void OrbBase()
    {
        levelUpMenuManager.upgradeButtons.AddRange(levelUpMenuManager.orbUpgrades);

    }

    public void OrbArea()
    {

    }

    public void OrbPlusOne()
    {

    }

    public void ExpAbsorb()
    {
        expAbsorb.transform.localScale += new Vector3(1, 1, 1);
    }

    public void MoveSpeed()
    {
        playerStats.moveStat += 1;
    }

    public void SwordSize()
    {
        sword.transform.localScale += new Vector3(1, 1, 1);
    }

    public void SwordDamage()
    {
        sword.damage += 1;
    }

    public void SwordSpeed()
    {
        sword.cooldown -= 0.5f;
    }

}
