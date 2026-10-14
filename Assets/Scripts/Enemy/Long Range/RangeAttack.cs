using UnityEngine;

public class RangeAttack : MonoBehaviour
{
    #region Variables

    public GameObject bulletSpawnObject;
    public BulletSpawner bulletSpawner;



    private RangeMovement movement;

    #endregion

    private void Awake()
    {
        movement = GetComponent<RangeMovement>();
        bulletSpawnObject = GameObject.FindGameObjectWithTag("BulletSpawner");
        bulletSpawner = bulletSpawnObject.GetComponentInChildren<BulletSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        Attacking();
    }

    private void Attacking()
    {
        if (movement.shootingRange == true)
        {
            bulletSpawner.SpawnObject();
        }
    }
}
