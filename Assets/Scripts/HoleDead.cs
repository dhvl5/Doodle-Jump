using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleDead : MonoBehaviour
{
    public Transform player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameManager>().Death();
        Vector3 newPos = new Vector3(0, 0, -10);
        player.transform.position = newPos;
    }
}
