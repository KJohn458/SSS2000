using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public int thrust = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        DestroyObjectDelayed();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb2d.AddForce(transform.up * thrust);
    }
    private void DestroyObjectDelayed()
    {
        Destroy(gameObject , 1);
    }
}
