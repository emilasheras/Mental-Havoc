using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public Transform SpawnPoint;
    public GameObject[] Enemies;

    private int rand;

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
          Instantiate(Enemies[0],SpawnPoint.transform.position, Quaternion.identity);
        }


    }
}
