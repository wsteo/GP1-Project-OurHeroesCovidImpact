using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameOver = false;

    // Update is called once per frame
    void Update()
    {
        if(gameOver == true)
        {
            return;
        }

        if(PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }
    void EndGame()
    {
        Debug.Log("GAME OVER!");
        gameOver = true;
    }
}
