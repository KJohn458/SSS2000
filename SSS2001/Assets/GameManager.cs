﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    //number of enemies

    private int monsters = 0;

    //player HP

    private int hp;

    //ammo (eventually)

    private int ammo = 6;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
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

    public void subAmmo()
    {
        ammo--;
    }

    public void resetAmmo()
    {

        ammo = 6;

    }


}
