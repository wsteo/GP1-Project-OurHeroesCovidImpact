using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameOver = false;
    public float restartDelay;

    // Update is called once per frame
    void Update()
    {
        if(gameOver == true)
        {
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }

        if(PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }
    void EndGame()
    {
        gameOver = true;
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
