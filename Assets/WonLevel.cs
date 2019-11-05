using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WonLevel : MonoBehaviour
{
    public void cont()
     {
         SceneManager.LoadScene(0);

         //SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
     }

    public void menu()
    {
        SceneManager.LoadScene(0);
    }

}
