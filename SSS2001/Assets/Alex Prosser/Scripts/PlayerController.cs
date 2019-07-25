using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float moveSpeed;
    private Rigidbody2D rigidbody2D;
    public GameManager gameManager;
    public Quaternion shootingRotation;
    public AudioClip deathSoundEffect;
    public AudioClip meleeSoundEffect;
    public AudioClip gunSoundEffect;
    private AudioSource audio;

    void Start() {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        audio = gameObject.GetComponent<AudioSource>();
    }

    void Update() {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (Input.GetAxis("Fire1") > 0) audio.PlayOneShot(gunSoundEffect, 1);
        if (Input.GetAxis("Fire2") > 0) audio.PlayOneShot(meleeSoundEffect, 1);
        if (Input.GetKey(KeyCode.Space)) audio.PlayOneShot(deathSoundEffect, 1);

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