using System.Collections;
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

    int GetHealth()
    {

        return hp;

    }

    void SetHP(int a)
    {

        hp = a;

    }

    void ManageHP(int a)
    {

        hp += a;

    }

    int GetMonsters()
    {

        return monsters;

    }

    void AddMonsters(int a)
    {

        monsters += a;
        
    }

    void SubMonsters()
    {

        monsters --;

    }

   int getAmmo()
    {
        return ammo;
    }

   void subAmmo()
    {
        ammo--;
    }

   void resetAmmo()
    {

        ammo = 6;

    }


}
