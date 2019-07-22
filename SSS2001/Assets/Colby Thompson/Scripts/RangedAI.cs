using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAI : MonoBehaviour
{
    public Transform Sprite;
    int MoveSpeed = 4;
    int MinDist = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
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

