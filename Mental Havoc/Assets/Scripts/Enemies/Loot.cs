﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Loot : MonoBehaviour
{
    public List<CreateNewItem> items;
    private CreateNewItem[] items2;
    

    public int randomNumber;
    public int total;
    
    public GameObject Award;
    
   private void Start()
   {
    
    foreach (var item in items)

    {
        total += item.DropChance;
    }


    randomNumber = Random.Range(0,total);

    Debug.Log(total);


    for (int i = 0; i < items[i].DropChance; i++ )
    {
        if (randomNumber <= items[i].DropChance)
        {
            Debug.Log(items[i]);
        }
        else
        {
            randomNumber -= items[i].DropChance;
        }


    }

    }
}




