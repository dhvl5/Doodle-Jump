using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField]
    Text scoreText;
    [SerializeField]
    Text gameOverText;
    public GameObject platformPrefab;

    public void ShowScoreText(int _score)
    {
        scoreText.text = "Score : " + _score.ToString();
    }

    public void ShowGameOverText()
    {
        gameOverText.gameObject.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        platformPrefab.SetActive(true);
    }
    
}
