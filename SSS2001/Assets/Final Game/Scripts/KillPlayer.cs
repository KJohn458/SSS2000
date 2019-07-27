using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public GameObject gameManger;
    public GameManager gmScript;
	private bool stopHittingMePlease = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && stopHittingMePlease == false)
        {
            gmScript.ManageHP(-1);
			stopHittingMePlease = true;
            Destroy(gameObject);
			gmScript.SubMonsters();
        }
    }
    private void Start()
    {
        gameManger = GameObject.FindGameObjectWithTag("GameManager");
        gmScript = gameManger.GetComponent<GameManager>();
    }

	private void Update()
	{
		stopHittingMePlease = false;
	}
}
