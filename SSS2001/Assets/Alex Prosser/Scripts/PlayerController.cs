using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float moveSpeed;
    private Rigidbody2D rigidbody2D;
    public GameManager gameManager;
    public Quaternion shootingRotation;
    public AudioSource death;

    void Start() {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update() {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (Input.GetKey(KeyCode.Space)) death.Play();

        rigidbody2D.MovePosition(rigidbody2D.position + (movement * moveSpeed * Time.deltaTime));

        Vector3 mouseScreen = Input.mousePosition;
        Vector3 mouse = Camera.main.ScreenToWorldPoint(mouseScreen);

        shootingRotation = Quaternion.Euler(0, 0, Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x) * Mathf.Rad2Deg - 90);
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