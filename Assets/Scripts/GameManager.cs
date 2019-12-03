using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public static bool gameOver;

   public GameObject gameOverUI;
   public GameObject wonLevelUI;

    void Start()
    {
        //set it to false so that even when you restart the game it will still be false
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
            return;

        if (PlayerStats.Lives <= 0)
        {
            LoseGame();
        }

        if(WaveSpawner.EnemiesKilled == 20)
        {
            WinLevel();
        }
    }

    void LoseGame()
    {
        gameOver = true;
        gameOverUI.SetActive(true);
    }

    public void WinLevel()
    {
        gameOver = true;
        wonLevelUI.SetActive(true);
    }
    
}
