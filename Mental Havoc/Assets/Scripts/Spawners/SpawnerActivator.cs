using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerActivator : MonoBehaviour
{
    public GameObject Spawner;
    public GameObject Button;
    public Progression Progression;

    
    public void ActiveGameObject()
    {   

        StartCoroutine(SpawnerSetActive());
        
        Progression.speed = Progression.speed + 0.1f;
        Progression.damage = Progression.damage + 0.5f;
        Progression.health = Progression.health + 1;

    }
    IEnumerator SpawnerSetActive()
    {
        yield return new WaitForSeconds(10);
        Spawner.SetActive(true);
        Button.SetActive(true);
        Debug.Log("holis");
        
    }
    
}
