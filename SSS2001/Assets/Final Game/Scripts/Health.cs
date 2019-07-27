using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject gameManager;
    public GameManager gmScript;
    public int CurrentHP;
    private Animator anim;


    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        gmScript = gameManager.GetComponent<GameManager>();
        anim = GetComponent<Animator>();

    }
    private void Update()
    {
        CurrentHP = gmScript.GetHealth();
        if (CurrentHP <= 0)
        {
            anim.SetBool("IsDead", true);
            Destroy(gameObject, 2);
        }
    }
}
