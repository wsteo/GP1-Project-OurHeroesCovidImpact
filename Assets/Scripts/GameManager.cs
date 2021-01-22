using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool gameOver;
    public bool isOver;

    public GameObject gameOverUI;
    public GameObject completeLvlUI;


    private void Start()
    {
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
            return;
        
        if (PlayerStats.Lives <= 0)
        {
            EndGame();
            isOver = gameOver;
        }
    }
    void EndGame()
    {
        gameOver = true;
        FindObjectOfType<AudioManager>().Play("PlayerLose");
        gameOverUI.SetActive(true);
    }

    public void WinLevel()
    {
        gameOver = true;
        completeLvlUI.SetActive(true);
    }
}
