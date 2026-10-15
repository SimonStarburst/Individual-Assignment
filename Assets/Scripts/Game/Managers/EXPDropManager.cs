using UnityEngine;

public class EXPDropManager : MonoBehaviour
{
    #region Variables
    public EXPPool expPool;
    public float dropDistance;
    public GameObject dropTarget;
    public Vector2 spawnPosition;


    #endregion

    private void Awake()
    {
        dropTarget = GameObject.FindGameObjectWithTag("Enemy");

    }
    public void SpawnEXP(Vector2 spawnPosition)
    {
        dropDistance = Random.Range(1f, 3f);
        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        GameObject exp = expPool.GetPooledObj();
        exp.transform.position = spawnPosition;
        exp.SetActive(true);
    }
}
