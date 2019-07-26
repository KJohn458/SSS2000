using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PortalBlock : MonoBehaviour
{
    private GameManager gameManager;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.GetMonsters() <= 0) {
            Destroy(gameObject);
            text.text = "Portal has been opened!";
        }
    }
}