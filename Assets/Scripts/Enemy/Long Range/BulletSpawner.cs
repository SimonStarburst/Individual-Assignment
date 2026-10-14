using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    #region Variables

    public BulletPool bulletPool;

    public GameObject target;
    public Vector2 targetPosition;

    public float spawnInterval = 1f;
    public float spawnDistance = 12f;
    public float bulletSpeed;
    public Vector2 spawnPosition;
    #endregion

    private void Update()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }



    public void SpawnObject()
    {
        // Aims in on where the Player is at the point of this being called
        targetPosition = target.transform.position;

        spawnPosition = gameObject.transform.position;
        GameObject bullet = bulletPool.GetPooledObj();
        bullet.transform.position = spawnPosition;
        bullet.SetActive(true);
        
    }
}
