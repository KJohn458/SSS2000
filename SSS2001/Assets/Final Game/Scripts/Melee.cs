using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour
{
    public Collider2D melee;
    public GameObject gameManager;
    public GameManager gmScript;

    // Start is called before the first frame update
    void Start()
    {
        DestroyObjectDelayed();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
        if (collision.tag == "Wall")
        {
            Destroy(gameObject);
        }
        if (collision.tag == "Blobby")
        {
            //gmScript.ManageBlobbyHP(-1);
        }

    }
    private void DestroyObjectDelayed()
    {
        Destroy(gameObject, 0.1f);
    }
}
