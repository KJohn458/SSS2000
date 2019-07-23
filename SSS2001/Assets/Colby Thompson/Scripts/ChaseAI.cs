using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseAI : MonoBehaviour
{
    public Transform Sprite;
    public int MoveSpeed = 4;
    public int MinDist = 1;

    void Update()
    {
        transform.LookAt(Sprite.position);
        transform.Rotate(new Vector3(0, -90, 0));

        if (Vector3.Distance(transform.position, Sprite.position) >= MinDist)
        {
            transform.Translate(new Vector3(MoveSpeed * Time.deltaTime, 0, 0));
        }
    }
}

