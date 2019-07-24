﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public GameObject gameManger;
    public GameManager gmScript;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gmScript.ManageHP(-1);
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        gameManger = GameObject.FindGameObjectWithTag("GameManager");
        gmScript = gameManger.GetComponent<GameManager>();
    }

}
