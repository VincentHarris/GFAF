
using UnityEngine;

public class LevelSelector : MonoBehaviour
{
    public SceneFader fader;

    public void Select (string levelName)
    {
        fader.FadeTo(levelName);
    }
   /*
    // Start is called before the first frame update
    void Start()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
       // SceneManager.LoadScene("Level2", LoadSceneMode.Additive);
    }
    */
}
