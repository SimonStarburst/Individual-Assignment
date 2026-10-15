using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    #region Variables

    public BulletPool bulletPool;

    public GameObject target;
    public Vector2 targetPosition;
    private float attackTimer;
    public float spawnInterval;
    public float bulletSpeed;
    public Vector2 spawnPosition;
    #endregion

    private void Update()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        attackTimer += Time.deltaTime;
    }

    public void SpawnObject(Vector2 spawnPosition)
    {
        targetPosition = target.transform.position;      
        GameObject bullet = bulletPool.GetPooledObj(); 
        bullet.transform.position = spawnPosition;        
        bullet.SetActive(true);
    }
}
