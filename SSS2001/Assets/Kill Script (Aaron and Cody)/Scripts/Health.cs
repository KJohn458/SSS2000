using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject gameManager;
    public GameManager gmScript;
    public int MaxHP;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        gmScript = gameManager.GetComponent<GameManager>();
        gmScript.SetHP(MaxHP);

    }
}
