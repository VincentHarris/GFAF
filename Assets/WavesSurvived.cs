using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class WavesSurvived : MonoBehaviour
{
    public Text WavesText;

    void OnEnable ()
    {
        WavesText.text = PlayerStats.Waves.ToString();
    }

    IEnumerator AnimateText ()
    {
        WavesText.text = "0";
        int wave = 0;

        yield return new WaitForSeconds(.7f);

        while (wave < PlayerStats.Waves )
        {
            wave++;
            WavesText.text = wave.ToString();

            yield return new WaitForSeconds(.05f);
        }
    }
}
