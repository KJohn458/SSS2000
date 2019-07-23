using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life: MonoBehaviour
{
    public Rigidbody projectile;
    public Transform barrelEnd;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("fire"))
        { 
        Rigidbody projectileInstance;
        projectileInstance = Instantiate(projectile, barrelEnd.position, barrelEnd.rotation);
        projectile.AddForce(barrelEnd.up * 350f);
      }
    }
}
