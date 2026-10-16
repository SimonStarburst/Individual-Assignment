using System.Collections;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    #region Variables
    [Header("Pools")]
    public ObjectPool closeSmallPool;
    public ObjectPool closeBigPool;
    public ObjectPool rangeSmallPool;
    public ObjectPool rangeBigPool;

    GameObject target;

    [Header("Spawn Intervals")]
    public float closeSmallInterval = 1f;
    public float closeBigInterval = 1f;
    public float rangeSmallInterval = 1f;
    public float rangeBigInterval = 1f;



    public float spawnDistance = 12f;
    public Vector2 spawnPosition;
    #endregion

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnCloseSmallCoroutine());
        StartCoroutine(SpawnCloseBigCoroutine());
        StartCoroutine(SpawnRangeSmallCoroutine());
        StartCoroutine(SpawnRangeBigCoroutine());
    }

    private void Update()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    IEnumerator SpawnCloseSmallCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(closeSmallInterval);
            SpawnCloseSmallObject();
        }
    }
    IEnumerator SpawnCloseBigCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(closeBigInterval);
            SpawnCloseBigObject();
        }
    }
    IEnumerator SpawnRangeSmallCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(rangeSmallInterval);
            SpawnRangeSmallObject();
        }
    }
    IEnumerator SpawnRangeBigCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(rangeBigInterval);
            SpawnRangeBigObject();
        }
    }

    private void SpawnCloseSmallObject()
    {
        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        spawnPosition = target.transform.position + (Vector3)(randomDirection * spawnDistance);
        GameObject enemy = closeSmallPool.GetPooledObj();
        enemy.transform.position = spawnPosition;
        enemy.SetActive(true);
    }

    private void SpawnCloseBigObject()
    {
        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        spawnPosition = target.transform.position + (Vector3)(randomDirection * spawnDistance);
        GameObject enemy = closeBigPool.GetPooledObj();
        enemy.transform.position = spawnPosition;
        enemy.SetActive(true);
    }

    private void SpawnRangeSmallObject()
    {
        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        spawnPosition = target.transform.position + (Vector3)(randomDirection * spawnDistance);
        GameObject enemy = rangeSmallPool.GetPooledObj();
        enemy.transform.position = spawnPosition;
        enemy.SetActive(true);
    }

    private void SpawnRangeBigObject()
    {
        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        spawnPosition = target.transform.position + (Vector3)(randomDirection * spawnDistance);
        GameObject enemy = rangeBigPool.GetPooledObj();
        enemy.transform.position = spawnPosition;
        enemy.SetActive(true);
    }

    public void StopSpawning()
    {
        StopCoroutine(SpawnCloseSmallCoroutine());
        StopCoroutine(SpawnCloseBigCoroutine());
        StopCoroutine(SpawnRangeSmallCoroutine());
        StopCoroutine(SpawnRangeBigCoroutine());
    }
}
