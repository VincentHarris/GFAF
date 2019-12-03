using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WonLevel : MonoBehaviour
{  
    public SceneFader fader;
    public string menuSceneName = "mainmenu";
    public string nextLevelName2 = "Level2";
    public string nextLevelName3 = "Level3";
    
    public void cont()
     {
        //Toggle();
        fader.FadeTo(nextLevelName2);
         //SceneManager.LoadScene(0);

         //SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
     }

 public void cont2()
     {
        //Toggle();
        fader.FadeTo(nextLevelName3);
         //SceneManager.LoadScene(0);

         //SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
     }
    public void menu()
    {
        //Toggle();
        fader.FadeTo(menuSceneName);
    }

    public void end()
    {
       Debug.Log("QUIT THE GAME");
        Application.Quit();
    }

    /*
    public void Toggle()
    {
        //this will flip the state of ui
        ui.SetActive( !ui.activeSelf ); 

        if (ui.activeSelf)
        {
            //this makes sure that the game actually pauses when the pause screen is up
            Time.timeScale = 0f; 
        } else
        {
            //Unpauses time
            Time.timeScale = 1f;
        }
    }

*/
}
