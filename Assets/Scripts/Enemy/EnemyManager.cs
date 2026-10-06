using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public ObjectPool enemyPool;
    public float spawnInterval = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void SpawnObject()
    {
        GameObject enemy = enemyPool.GetPooledObject();
        enemy.transform.position = 
    }

}
