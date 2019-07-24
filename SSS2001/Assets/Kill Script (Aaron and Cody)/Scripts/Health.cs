using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private GameObject gameManager;
    private GameManager gmScript;
    private int MaxHP;
    private int CurrentHP;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        gmScript = gameManager.GetComponent<GameManager>();
        gmScript.SetHP(MaxHP);

    }
    private void Update()
    {
        CurrentHP = gmScript.GetHealth();
        if (CurrentHP == 0)
        {
            Destroy(gameObject);
        }
    }
}
