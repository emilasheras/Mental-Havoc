using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public Transform[] SpawnPoint;
    public GameObject[] Enemies;

    private int rand;
    private int randPosition;

    public float StartTimeBtwSpawns;
    private float TimeBtwSpawns;


    private void Start() 
    {

        TimeBtwSpawns = StartTimeBtwSpawns;

    }
    private void Update() 
    {

        if (TimeBtwSpawns <= 0)

        {  
          rand = Random.Range(0, Enemies.Length);
          randPosition = Random.Range(0, SpawnPoint.Length);
          Instantiate(Enemies[rand],SpawnPoint[randPosition].transform.position, Quaternion.identity);
          TimeBtwSpawns = StartTimeBtwSpawns;
        }
        else
        {
            TimeBtwSpawns -= Time.deltaTime;
        }



    }
}
