using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject Projectile;
    public GameObject BulletSpawn;
    
    private Vector3 Position;
    Quaternion rotation;
    
    private void Start()
    {
      
    }
    void Update()
    {
        Position = BulletSpawn.transform.position;
        rotation = BulletSpawn.transform.rotation;
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(Projectile, Position, rotation);
        }

    }

}
