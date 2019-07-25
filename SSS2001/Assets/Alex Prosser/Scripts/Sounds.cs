using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioClip death;
    public AudioSource deathSource;

    // Start is called before the first frame update
    void Start()
    {
        deathSource = new AudioSource();
        Debug.Log(deathSource);
        deathSource.clip = death;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space)) deathSource.Play();
    }
}