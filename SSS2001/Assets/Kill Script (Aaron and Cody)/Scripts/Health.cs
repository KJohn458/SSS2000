using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject gameManager;
    public GameManager gmScript;
    public int MaxHP;
    public int CurrentHP;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        gmScript = gameManager.GetComponent<GameManager>();
        gmScript.SetHP(MaxHP);

    }
    private void Update()
    {
        CurrentHP = gmScript.GetHealth();
        if (CurrentHP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
