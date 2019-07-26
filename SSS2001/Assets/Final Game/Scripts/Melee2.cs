using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee2 : MonoBehaviour
{
    public GameObject Melee;
    public GameObject Spawn;
    private Vector3 Position;
    Quaternion rotation;
    private PlayerController player;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        Position = Spawn.transform.position;
        rotation = player.shootingRotation;
        if (Input.GetButtonDown("Fire2"))
        {
            Instantiate(Melee, Position, rotation);
        }

    }

}
