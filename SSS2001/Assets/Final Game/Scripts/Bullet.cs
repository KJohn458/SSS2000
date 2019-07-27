using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public int thrust = 100;
    private GameManager gameManager;
    private EnemyHealth eHealth;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        rb2d = GetComponent<Rigidbody2D>();
        DestroyObjectDelayed();
        transform.rotation.Set(0f, 0f, 90f, 0);
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //gameManager.SubMonsters();
            eHealth = other.GetComponent<EnemyHealth>();
            eHealth.DamageEnemy();
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}
