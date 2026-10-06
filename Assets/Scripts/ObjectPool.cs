using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Pool;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab; // Prefab to pool from
    public int poolSize = 10;

    private List<GameObject> pool;

    void Start()
    {
        //Initialize the object pool
        InitializePool();
    }

    private void InitializePool()
    {
        pool = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            CreateNewObj();
        }
    }

    public GameObject GetPooledObject()
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
