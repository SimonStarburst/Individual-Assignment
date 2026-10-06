using System.Collections;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public ObjectPool closeSmallPool;
    public ObjectPool closeBigPool;
    public ObjectPool rangeSmallPool;
    public ObjectPool rangeBigPool;

    public Transform player;

    public float spawnInterval = 1f;
    public float spawnDistance = 12f;
    public Vector2 spawnPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnEnemyCoroutine());
    }

    private void Update()
    {
        player = player.transform;
    }

    IEnumerator SpawnEnemyCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        spawnPosition = player.position + (Vector3)(randomDirection * spawnDistance);
        GameObject enemy = closeSmallPool.GetPooledObject();
        enemy.transform.position = spawnPosition;
        enemy.SetActive(true);
    }
}
