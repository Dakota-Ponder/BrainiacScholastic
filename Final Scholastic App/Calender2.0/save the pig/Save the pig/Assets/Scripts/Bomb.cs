using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float RotationSpeed;


    private void FixedUpdate()
    {
        transform.Rotate(0, 0, RotationSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }

        else if(collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}

