using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

   // public Text WavesText;

    /*void OnEnable ()
    {
        WavesText.text = PlayerStats.Waves.ToString();
    }
    */
    public void tryAgain ()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
    }

    public void menu()
    {
        SceneManager.LoadScene(0);
    }

}
