using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
//NOTE: All the lines with "added in" comments are needed so that the enemies actually die
//Without them either
// a) They still die in one hit 
// b) They don't die no matter how many hits they take


   public float speed = 8f;
   public float startHealth = 100; // added in
   private float health; // added in

   public int moneygain = 50;
   public GameObject deathEffect;

   [Header("Unity Stuff")]
   public Image healthbar;

   private bool isDead = false;
   
   //public int health = 100;

   private Transform target;
   private int wavepointIndex = 0;


   void Start()
   {
       health = startHealth; //added in

       target = Waypoints.points[0]; //sets target to 1st waypoint
   }

   public void TakeDamage (int amount)
   {
       health -= amount;
       // healthbar.fillAmount = health / startHealth;

       //            |-added in|
       if (health <=0 && !isDead)
       {
           Die();
       }
   }

    void Die()
    { 
        PlayerStats.Money += moneygain;
        
        GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);

        WaveSpawner.EnemiesAlive--;
        WaveSpawner.EnemiesKilled++;
        
        isDead = true; //added in
        Destroy(gameObject);
    }


   void Update()
   {
       //moves enemy towards waypoint
       Vector3 dir = target.position - transform.position;
       transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
       
       // when it reaches the waypoint it will call GetNextWayPoint
       if (Vector3.Distance(transform.position, target.position) <= 0.5f)
       {
           GetNextWaypoint();
       }
       transform.LookAt(target);
   }
    //moves the target from the current waypoint to the next
   void GetNextWaypoint()
   {    
       // if the enemy makes it to the end, it will be destroyed 
       if(wavepointIndex >= Waypoints.points.Length - 1)
       {
           EndPath();
           return;
       }

       wavepointIndex++;
       target = Waypoints.points[wavepointIndex];
   }

    void EndPath()
    {
        PlayerStats.Lives--;
        WaveSpawner.EnemiesAlive--;
        Destroy(gameObject);
    }

}
