using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    public GameObject enemy;
    public float delayInSeconds;
    private float currentDelay;
    void Start()
    {
        currentDelay = delayInSeconds;
    }

    // Update is called once per frame
    void Update()
    {
        currentDelay -= Time.deltaTime;

        if (currentDelay <= 0) {
            Debug.Log("Spawn");
            currentDelay = delayInSeconds;
            Instantiate(enemy, transform.position, transform.rotation);
        }
    }
}