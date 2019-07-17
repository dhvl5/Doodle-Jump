using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerScript : MonoBehaviour
{
    public GameManager gameManagerScript;
    private float speed = 20f;
    SpriteRenderer mySpriteRenderer;
    Rigidbody2D rb2d;
    float movement = 0f;
    float playerPos;
    public int score=0;
    
    public Camera yourCam;

    void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        playerPos = transform.position.y;
	}

    void Update()
    {
        //movement = Input.acceleration.x * speed;
        movement = Input.GetAxis("Horizontal") * speed;
        Flip();
        SetScore();
        Vector3 pos = transform.position;
        float HalfScreenSize = yourCam.aspect * yourCam.orthographicSize;
        pos.x = Mathf.Repeat(pos.x + HalfScreenSize, HalfScreenSize * 2) - HalfScreenSize;
        transform.position = pos;
    }

    void Flip()
    {
        if (Input.acceleration.x < 0) mySpriteRenderer.flipX = true;
        else if (Input.acceleration.x > 0) mySpriteRenderer.flipX = false;
    }

    /*void Flip()
    {
        if (Input.GetAxisRaw("Horizontal") < 0) mySpriteRenderer.flipX = true;
        else if (Input.GetAxisRaw("Horizontal") > 0) mySpriteRenderer.flipX = false;
    }*/

    void SetScore()
    {
        score = Mathf.Max(score, Mathf.FloorToInt(transform.position.y - playerPos));
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb2d.velocity;
        velocity.x = movement;
        rb2d.velocity = velocity;
    }
}
