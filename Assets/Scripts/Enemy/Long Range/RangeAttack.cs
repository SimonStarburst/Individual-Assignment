using System.Collections;
using UnityEngine;

public class RangeAttack : MonoBehaviour
{
    #region Variables

    public GameObject bulletSpawnObject;
    public BulletSpawner bulletSpawner;

    [SerializeField] private float bulletInterval;
    public float attackTimer = 0f;

    private RangeMovement movement;

    #endregion

    private void Awake()
    {
        movement = GetComponent<RangeMovement>();
        bulletSpawnObject = GameObject.FindGameObjectWithTag("BulletSpawner");
        bulletSpawner = bulletSpawnObject.GetComponentInChildren<BulletSpawner>();
    }

    private void Start()
    {
        //StartCoroutine(SpawnBulletCoroutine());
    }

    void Update()
    {
        attackTimer += Time.deltaTime;
        Attacking();
    }

    //IEnumerator SpawnBulletCoroutine()
    //{
    //    if (movement.shootingRange == true)
    //    {            
    //        yield return new WaitForSeconds(1);
    //        bulletSpawner.SpawnObject();
    //        Debug.Log("Bullet Shot!");
    //    }
    //}

    private void Attacking()
    {
        if (movement.shootingRange == true && attackTimer > bulletInterval)
        {
            bulletSpawner.SpawnObject();
            Debug.Log("Bullet Shot!");
        }
    }
}
