using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spit : MonoBehaviour
{
    public float speed;

    // gamemanger stuff
    public GameObject gameManger;
    public GameManager gmScript;
    private GameManager gameManager;

    private Transform player;
    private Vector2 target;

    void Start()
    {
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
        gameManger = GameObject.FindGameObjectWithTag("GameManager");
        gmScript = gameManger.GetComponent<GameManager>();
        DestroyObjectDelayed();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            DestroyProjectile();
        }
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
    void DestroyProjectile(){
        gmScript.ManageHP(-1);
        Destroy(gameObject);
    }
    private void DestroyObjectDelayed()
    {
        Destroy(gameObject, 5f);
    }
}
