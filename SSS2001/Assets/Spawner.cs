using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Mob;
    void Start()
    {
        Instantiate(Mob, transform.position, transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
