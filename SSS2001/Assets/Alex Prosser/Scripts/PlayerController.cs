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
    public float staminaLengthInSeconds;
    private AudioSource audio;
    private bool gunSound, meleeSound, running;
    private float stamina;

    void Start() {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        audio = gameObject.GetComponent<AudioSource>();
        stamina = staminaLengthInSeconds;
    }

    void Update() {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (Input.GetAxis("Fire1") > 0 && !gunSound)
        {
            audio.PlayOneShot(gunSoundEffect, 1);
            gunSound = true;
        }
        else if (Input.GetAxis("Fire1") == 0) {
            gunSound = false;
        }
        if (Input.GetAxis("Fire2") > 0 && !meleeSound)
        {
            audio.PlayOneShot(meleeSoundEffect, 1);
            meleeSound = true;
        }
        else if (Input.GetAxis("Fire2") == 0)
        {
            meleeSound = false;
        }

        rigidbody2D.MovePosition(rigidbody2D.position + (movement * moveSpeed * Time.deltaTime));

        Vector3 mouseScreen = Input.mousePosition;
        Vector3 mouse = Camera.main.ScreenToWorldPoint(mouseScreen);

        float angle = Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x) * Mathf.Rad2Deg;

        shootingRotation = Quaternion.Euler(0, 0, angle - 90);

        gameObject.transform.Find("Gun").gameObject.transform.rotation = Quaternion.Euler(0, 0, angle);

        if (angle < 90 && angle > -90)
        {
            gameObject.transform.Find("Gun").gameObject.transform.Find("Sprite").GetComponent<SpriteRenderer>().flipY = false;
        }
        else
        {
            gameObject.transform.Find("Gun").gameObject.transform.Find("Sprite").GetComponent<SpriteRenderer>().flipY = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && stamina > 0)
        {
            moveSpeed += 10;
            running = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed -= 10;
            running = false;
        }

        if (running)
        {
            stamina -= Time.deltaTime;
        }
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