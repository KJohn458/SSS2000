using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject Projectile;
    public GameObject Spawn;
    private PlayerController player;

    public GameObject gameManager;
    public GameManager gmScript;
    public int CurrentAmmo;
    
    private Vector3 Position;
    Quaternion rotation;
    
    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<PlayerController>();

        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        gmScript = gameManager.GetComponent<GameManager>();
    }
    void Update()
    {
        Position = Spawn.transform.position;
        rotation = player.shootingRotation;
        if (Input.GetButtonDown("Fire1") && CurrentAmmo > 0)
        {
            Instantiate(Projectile, Position, rotation);
            gmScript.ManageAmmo(-1);
        }

    }

    private void FixedUpdate()
    {
        CurrentAmmo = gmScript.getAmmo();
    }

}
