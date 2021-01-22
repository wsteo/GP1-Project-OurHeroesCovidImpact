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
        isOver = gameOver;
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

            WaveSpawner spawner = GetComponent<WaveSpawner>();
            spawner.enabled = false;
        }
    }
    private void EndGame()
    {
        gameOver = true;
        FindObjectOfType<AudioManager>().Play("PlayerLose");
        WaveSpawner.EnemiesAlive = 0;
        gameOverUI.SetActive(true);
    }

    public void WinLevel()
    {
        gameOver = true;
        completeLvlUI.SetActive(true);
    }
}
