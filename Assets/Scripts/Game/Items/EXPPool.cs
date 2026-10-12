using System.Collections.Generic;
using UnityEngine;

public class EXPPool : MonoBehaviour
{
    #region Variables

    public GameObject prefab;       // Prefab to pool from
    public int poolSize;       // Amount of objects to be instantiated at start
    public int currentPoolSize;     // Current amount in pool
    public int maxPoolSize = 100;   // Max amount of enemies in pool
    private Health enemyHealth;

    private List<GameObject> pool;  // List of pooled objects

    #endregion

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyHealth = GetComponent<Health>();        
        //Initialize the object pool
        InitializePool();
    }

    // Update is called once per frame
    void Update()
    {
        currentPoolSize = pool.Count;
    }

    private void InitializePool()
    {
        pool = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            CreateNewObj();
        }
    }
    public GameObject GetPooledObj()
    {
        foreach (GameObject obj in pool)
        {
            // Check if there are any inactive objects in the pool
            if (!obj.activeInHierarchy)
            {
                return obj;
            }
        }
        // If there's no inactive object in the pool, create a new object and adds it to the pool
        return CreateNewObj();
    }


    private GameObject CreateNewObj()
    {
        GameObject obj = Instantiate(prefab, transform);
        obj.SetActive(false);
        pool.Add(obj);
        return obj;
    }
}
