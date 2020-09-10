using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Loot 
{
    /*
    En el futuro va a ser un sistema de Loot
    
    */
    public int RandomNumber;

    void LootTable()
    {

    RandomNumber = Random.Range(0,100);
    
         if (RandomNumber <= 70) //30%
        {
            Debug.Log("DOOOOU");
        }

    }
}
