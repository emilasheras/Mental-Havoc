using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Loot : MonoBehaviour
{
    public CreateNewItem[] items;
    
    

    public int randomNumber;
    public int total;
    
    
   private void Start()
   
   {
    if (items.Length == 4)
    { 
        total = items[0].DropChance + items[1].DropChance + items[2].DropChance + items[3].DropChance;
    }
    else if(items.Length == 3)
    {
        total = items[0].DropChance + items[1].DropChance + items[2].DropChance;
    }
    else
    {
        total = 666;
    }


    Debug.Log(total);


    


   }

     
     


}


