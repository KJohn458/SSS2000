using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseAI : MonoBehaviour
{
    public float moveSpeed = 4f;
    public int minDist = 1;
    private Rigidbody2D rigidbody;
    private GameObject player;

    private void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player");
        Debug.Log(player);
    }

    void Update()
    {
        Vector3 dir = (player.transform.position - rigidbody.transform.position).normalized;

        if (Vector3.Distance(player.transform.position, rigidbody.transform.position) > minDist)
        {
            rigidbody.MovePosition(rigidbody.transform.position + dir * moveSpeed * Time.deltaTime);
        }
    }
}

