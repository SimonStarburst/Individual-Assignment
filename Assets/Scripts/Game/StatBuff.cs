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

    public void AuraBase()
    {

    }
    public void AuraArea()
    {

    }

    public void AuraDamage()
    {

    }

    public void LaserBase()
    {

    }

    public void LaserBounce()
    {

    }

    public void LaserCooldown()
    {

    }

    public void OrbBase()
    {

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
        sword.cooldown -= 0.2f;
    }

}
