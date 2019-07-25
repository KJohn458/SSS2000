using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spit : MonoBehaviour
{
    public float speed;

    // gamemanger stuff
    public GameObject gameManger;
    public GameManager gmScript;

    private Transform player;
    private Vector2 target;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
        gameManger = GameObject.FindGameObjectWithTag("GameManager");
        gmScript = gameManger.GetComponent<GameManager>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DestroyProjectile();
        }
    }
    void DestroyProjectile(){
        gmScript.ManageHP(-1);
        Destroy(gameObject);
    }
}
