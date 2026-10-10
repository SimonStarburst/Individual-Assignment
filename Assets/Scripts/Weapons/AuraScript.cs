using UnityEngine;

public class AuraScript : MonoBehaviour
{
    #region Variables

    [Header("Aura Stats")]
    public bool isEquipped;

    public float abilityTimer;

    // Affects how often the aura damage over time ticks occurs
    public float cooldown;

    // Affects the damage of the ura damage over time ticks
    public float damage;

    // Will affect size of aura
    public float size;

    #endregion

    private void Awake()
    {
        isEquipped = false;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        abilityTimer -= Time.deltaTime;
        CastAbility();
    }

    public void CastAbility()
    {
        if (abilityTimer > 0)
        {
            return;
        }
        abilityTimer = cooldown;
        Debug.Log("Aura Damage");
    }
}
