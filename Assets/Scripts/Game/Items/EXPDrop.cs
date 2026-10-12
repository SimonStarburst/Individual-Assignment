using System.Collections.Generic;
using UnityEngine;

public class EXPDrop : MonoBehaviour
{
    #region Variables
    public EXPPool expPool;
    public float dropDistance;
    GameObject dropTarget;
    public Vector2 dropPosition;


    #endregion

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        dropDistance = Random.Range(1f, 3f);
    }

    public void SpawnEXP()
    {
        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        dropPosition = dropTarget.transform.position + (Vector3)(randomDirection * dropDistance);
        GameObject exp = expPool.GetPooledObj();
        exp.transform.position = dropPosition;
        exp.SetActive(true);
    }
}
