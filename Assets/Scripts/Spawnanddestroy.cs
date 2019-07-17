using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawnanddestroy : MonoBehaviour
{

    public GameObject floorpre;
    public GameObject floorjump;
    public GameObject floordead;
    public new GameObject camera;
    private float maxY = 5f;
    private float jumpY = 60f;
    private float deadY = 130f;
    private float holeY = 250f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FindObjectOfType<GameManager>().Death();
        }
        if (collision.gameObject.tag == "floor")
        {
            Destroy(collision.gameObject);
            Instantiate(floorpre, new Vector3(Random.Range(-3, 3), camera.transform.position.y + maxY, 0), Quaternion.identity);
        }
        if(collision.gameObject.tag == "jumpFloor")
        {
            Destroy(collision.gameObject);
            Instantiate(floorjump, new Vector3(Random.Range(-3, 3), camera.transform.position.y + jumpY), Quaternion.identity);
        }
        if (collision.gameObject.tag == "deadFloor")
        {
            Destroy(collision.gameObject);
            Instantiate(floordead, new Vector3(Random.Range(-3, 3), camera.transform.position.y + deadY), Quaternion.identity);
        }
        if (collision.gameObject.tag == "deadHole")
        {
            Destroy(collision.gameObject);
            Instantiate(floordead, new Vector3(Random.Range(-3, 3), camera.transform.position.y + holeY), Quaternion.identity);
        }
    }
}
