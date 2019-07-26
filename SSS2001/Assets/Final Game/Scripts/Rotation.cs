using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public GameObject Player;
    public GameObject Spawn;
    private Vector3 Position;
    Quaternion rotation;

    private void Update()
    {
        Position = Spawn.transform.position;
        rotation = Player.transform.rotation;
    }

}
