using UnityEngine;
using System.Collections;
using UnityEngine.UI; //so we can reference a text object

public class WaveSpawner : MonoBehaviour
{
    public static int EnemiesAlive =0;
    public static int EnemiesKilled =0;

    public Wave[] waves;
    //public Transform enemyPrefab;
    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    public Text waveCountDownText;
    public GameManager gameManager;
    private int waveIndex = 0;

        void Update()
        {
            if(EnemiesAlive>0)
            {
                return;
            }

            if (EnemiesKilled ==20)//waveIndex == waves.Length)
            {
                gameManager.WinLevel();
                this.enabled = false;
            }

         //Spawns waves
         if (countdown <= 0f)
         {
             StartCoroutine(SpawnWave()); //runs the coroutine specified as Spawnwave
             countdown = timeBetweenWaves;
             
         }

            //after every wave, the countdown shortens
            countdown -= Time.deltaTime;
            countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);
            

            //MathF.Floor cuts off all the decimal places and only leaves the first one
            //TLDR; it rounds down to an integer, but keeps it as a float
            waveCountDownText.text = Mathf.Round(countdown).ToString();
        }

        //IEnumerator allows us to pause this code segment, whereas void doesn't
        IEnumerator SpawnWave () 
        {
            
            PlayerStats.Waves++;
            Wave wave = waves[waveIndex];

            for (int i = 0; i < wave.count; i++)
            {
                SpawnEnemy(wave.enemy);
                yield return new WaitForSeconds(1f/ wave.rate); 
            }
            waveIndex++;

        }

        void SpawnEnemy (GameObject enemy)
        {
            Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
            EnemiesAlive++;
        }
}
