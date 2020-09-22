using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Loot : MonoBehaviour
{
    public int[] table = {10,45,60};
    public int total;
    int RandomNumber;

    public CreateNewItem[] items;



    private void Start()
    {
        EventLootTable.eventLootTable += LootTable;

    }

    void LootTable()
    
    {



    }



}
