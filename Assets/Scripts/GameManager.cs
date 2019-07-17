using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    UIManager scoreScript;
    [SerializeField]
    PlayerScript playerScript;
    public GameObject button;

    public EdgeCollider2D boxCollider;
    public GameObject platform;

    public void Death()
    {
        GetComponent<AudioSource>().Play();
        button.SetActive(true);
        scoreScript.ShowGameOverText();
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene(0);
        }
        boxCollider.enabled = false;
        platform.SetActive(false);
    }

    void Update()
    {
        scoreScript.ShowScoreText(playerScript.score);
    }
}
