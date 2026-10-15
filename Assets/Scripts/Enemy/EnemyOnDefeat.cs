using UnityEngine;

public class EnemyOnDefeat : MonoBehaviour
{

    #region Variables

    private BaseStats enemyStats;
    private Health enemyHealth;

    public GameObject expSpawnObject;
    public EXPDropManager expSpawner;


    #endregion

    void Awake()
    {
        enemyHealth = GetComponent<Health>();
        expSpawnObject = GameObject.FindGameObjectWithTag("EXPSpawner");
        expSpawner = expSpawnObject.GetComponentInChildren<EXPDropManager>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void EXPDrop()
    {
        expSpawner.SpawnEXP(gameObject.transform.position);
    }

    private void Score()
    {

    }
}
