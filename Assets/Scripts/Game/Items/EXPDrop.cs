using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXPDrop : MonoBehaviour
{
    #region Variables
    public EXPPool expPool;
    public float dropDistance;
    public GameObject dropTarget;
    public GameObject expPooler;
    public Vector2 dropPosition;


    #endregion

    private void Awake()
    {
        dropTarget = gameObject;
        expPooler = GameObject.FindGameObjectWithTag("EXPPool");
        expPool = expPooler.GetComponentInChildren<EXPPool>();
    }
    public void SpawnEXP()
    {
        dropDistance = Random.Range(1f, 3f);
        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        dropPosition = dropTarget.transform.position + (Vector3)(randomDirection * dropDistance);
        GameObject exp = expPool.GetPooledObj();
        exp.transform.position = dropPosition;
        exp.SetActive(true);
    }
}
