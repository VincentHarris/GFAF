using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject ui;
    public SceneFader sceneFader;
    public string menuSceneName = "mainmenu";
    public string reload = "Level2";

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            Toggle();
        }
    }

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

    public void Retry ()
    {
        Toggle();
        sceneFader.FadeTo(reload);
        //sceneFader.FadeTo(SceneManager.GetActiveScene().name); 
       // WaveSpawner.EnemiesAlive = 0;
    }

    public void Menu ()
    {
        Toggle();
        sceneFader.FadeTo(menuSceneName);
       // WaveSpawner.EnemiesAlive = 0;
    }

//use this if scenefader doesn't work
/*
public void Retry ()
    {
        Toggle();
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu ()
    {
        Toggle();
        SceneManager.LoadScene(0);
    }
*/
}
