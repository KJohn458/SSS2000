using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject Projectile;
    public GameObject BulletSpawn;
    private PlayerController player;
    
    private Vector3 Position;
    Quaternion rotation;
    
    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
    }
    void Update()
    {
        Position = BulletSpawn.transform.position;
        rotation = player.shootingRotation;
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(Projectile, Position, rotation);
        }

    }

}
