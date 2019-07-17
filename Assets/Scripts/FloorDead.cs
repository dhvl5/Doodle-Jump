using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDead : MonoBehaviour
{
    float jump = 10f;
    //public GameObject platform;

    private void OnCollisionEnter2D(Collision2D collision)
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
                FindObjectOfType<GameManager>().Death();
                //platform.SetActive(false);
            }
        }
    }

}
