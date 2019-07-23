using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float moveSpeed;
    private Rigidbody2D rigidbody2D;
    public GameManager gameManager;

    void Start() {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rigidbody2D.MovePosition(rigidbody2D.position + (movement * moveSpeed * Time.deltaTime));

        Vector3 mouseScreen = Input.mousePosition;
        Vector3 mouse = Camera.main.ScreenToWorldPoint(mouseScreen);

        transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x) * Mathf.Rad2Deg - 90);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Health"))
        {
            gameManager.ManageHP(10);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Ammo"))
        {
            gameManager.ManageAmmo(10);
            Destroy(collision.gameObject);
        }
    }
}