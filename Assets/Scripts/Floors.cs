using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floors : MonoBehaviour
{

    float jump = 11f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0)
        {
            Rigidbody2D rb2d = collision.collider.GetComponent<Rigidbody2D>();
            if (rb2d != null)
            {
                Vector2 velocity = rb2d.velocity;
                velocity.y = jump;
                rb2d.velocity = velocity;
                GetComponent<AudioSource>().Play();
            }
        }
    }
}
