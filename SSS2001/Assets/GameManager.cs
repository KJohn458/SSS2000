using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    //number of enemies

    private int monsters = 0;

    //player HP

    private int hp;

    //ammo (eventually)

    [SerializeField]
    private int ammo ;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
  
    void Update()
    {
        Debug.Log(monsters);
    }

    public int GetHealth()
    {
        return hp;
    }

    public void SetHP(int a)
    {
        hp = a;
    }

    public void ManageHP(int a)
    {
        hp += a;
    }

    public void SetAmmo(int a)
    {
        ammo = a;
    }

    public int GetMonsters()
    {
        return monsters;
    }

    public void AddMonsters(int a)
    {
        monsters += a;
    }

    public void SubMonsters()
    {
        monsters --;
    }

    public void ManageAmmo(int a)
    {
        ammo += a;
    }

    public int getAmmo()
    {
        return ammo;
    }
}
