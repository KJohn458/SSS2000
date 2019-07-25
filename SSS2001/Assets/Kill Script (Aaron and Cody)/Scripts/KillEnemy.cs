using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{

    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            gameManager.SubMonsters();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }

}
