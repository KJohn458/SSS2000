﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAI : MonoBehaviour
{
    public Transform Sprite;
    [Header("Stats")]
    public float speed;
    public float stoppingDistance;
    public float nearDistance;
    public float startTimeBtwShots;
    private float timeBtwShots;

    [Header("References")]
    public GameObject shot;
    private Transform player;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        timeBtwShots = startTimeBtwShots;
    }

    void Update() {
        transform.LookAt(Sprite.position);
        transform.Rotate(new Vector3(0, -90, 0));

        if (Vector2.Distance(transform.position, player.position) > stoppingDistance) {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        } else if((Vector2.Distance(transform.position, player.position) < nearDistance)){
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        } else {
            transform.position = Vector2.MoveTowards(transform.position, player.position, 0);
        }

        if (timeBtwShots <= 0) {
            Instantiate(shot, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        } else {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
