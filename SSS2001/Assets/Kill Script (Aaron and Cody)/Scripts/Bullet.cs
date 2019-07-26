using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public int thrust = 100;
   
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        DestroyObjectDelayed();
        transform.rotation.Set(0f, 0f, 90f,0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb2d.AddForce(transform.up * thrust);
    }
    private void DestroyObjectDelayed()
    {
        Destroy(gameObject , 0.75f);
    }
}
