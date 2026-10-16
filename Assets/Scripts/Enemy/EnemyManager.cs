using System.Collections;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    #region Variables

    [SerializeField] private TimerScript timer;

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
        closeSmallInterval = 6;
        closeBigInterval = 16;
        rangeSmallInterval = 8;
        rangeBigInterval = 18;

        StartCoroutine(SpawnCloseSmallCoroutine());
        StartCoroutine(SpawnCloseBigCoroutine());
        StartCoroutine(SpawnRangeSmallCoroutine());
        StartCoroutine(SpawnRangeBigCoroutine());
        StartCoroutine(SpawnTimes());
    }

    private void Update()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    private void EnemySpawnTimer()
    {
        if (closeSmallInterval > 0.2f)
        {
            closeSmallInterval -= 0.2f;
        }

        else if (closeBigInterval > 0.2f)
        {
            closeBigInterval -= 0.2f;
        }

        else if (rangeSmallInterval > 0.2f)
        {
            rangeSmallInterval -= 0.2f;
        }

        else if (rangeBigInterval > 0.2f)
        {
            rangeBigInterval -= 0.2f;
        }

        else if (rangeBigInterval == 0.2f)
        {
            StopCoroutine(SpawnTimes());
        }

    }

    #region SpawnCoroutines

    // Every 30 seconds, this coroutine calls upon EnemySpawnTimer every 30 seconds
    // lowering the spawn interval for the enemies
    IEnumerator SpawnTimes()
    {
        while (true)
        {
            yield return new WaitForSeconds(30);
            EnemySpawnTimer();
        }
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
    #endregion


    #region Spawner Scripts
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
    #endregion

    public void StopSpawning()
    {
        StopCoroutine(SpawnCloseSmallCoroutine());
        StopCoroutine(SpawnCloseBigCoroutine());
        StopCoroutine(SpawnRangeSmallCoroutine());
        StopCoroutine(SpawnRangeBigCoroutine());
    }
}
