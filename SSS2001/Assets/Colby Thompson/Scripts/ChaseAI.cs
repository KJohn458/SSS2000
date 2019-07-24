using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseAI : MonoBehaviour
{
    public Transform sprite;
    public float moveSpeed = 4f;
    public int minDist = 1;
    private Rigidbody2D rigidbody;

    private void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 dir = (sprite.transform.position - rigidbody.transform.position).normalized;

        if (Vector3.Distance(sprite.transform.position, rigidbody.transform.position) > 0.1)
        {
            rigidbody.MovePosition(rigidbody.transform.position + dir * moveSpeed * Time.deltaTime);
        }
    }
}

