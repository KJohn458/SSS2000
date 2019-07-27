using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    public GameObject enemy;
    public float delayInSeconds;
    public int maxEnemies;
    private int currentEnemyCount;
    private GameManager gameManager;
    private float currentDelay;
    public bool isPickUp;
    void Start()
    {
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        currentDelay = delayInSeconds;
        currentEnemyCount = maxEnemies;
        if (!isPickUp) gameManager.AddMonsters(maxEnemies);
    }

    void Update()
    {
        currentDelay -= Time.deltaTime;

        if (currentDelay <= 0 && currentEnemyCount > 0) {
            currentDelay = delayInSeconds;
            Instantiate(enemy, transform.position, transform.rotation);
            currentEnemyCount--;
        }
    }
}