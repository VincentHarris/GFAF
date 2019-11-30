//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public SceneFader sceneFader;
    public string menuSceneName = "mainmenu";

   // public Text WavesText;

    /*void OnEnable ()
    {
        WavesText.text = PlayerStats.Waves.ToString();
    }
    */
    public void tryAgain ()
    {
        sceneFader.FadeTo(SceneManager.GetActiveScene().name);
    }

    public void menu()
    {
        sceneFader.FadeTo(menuSceneName);
    }

//use this if scene fader doesn't work
 /*
 public void tryAgain ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void menu()
    {
        SceneManager.LoadScene(0);
    }
*/
}
