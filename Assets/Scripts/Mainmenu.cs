using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public string levelToLoad = "Level1";
    public string levelToLoad2 = "LevelSelect";
    public SceneFader sceneFader;

    public void PlayGame() 
    {
        sceneFader.FadeTo(levelToLoad);//(SceneManager.GetActiveScene().buildIndex +1); 
    }

    public void QuitGame()
    {
        Debug.Log("QUIT THE GAME");
        Application.Quit();
    }

    public void LevelSelect()
    {
        sceneFader.FadeTo(levelToLoad2);
    }
}
