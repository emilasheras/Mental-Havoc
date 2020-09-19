using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Loot : MonoBehaviour
{

    public CreateNewItem[] items;

    int RandomNumber;

    private void Start()
    {
        EventLootTable.eventLootTable += LootTable;

    }

    void LootTable()
    {

      RandomNumber = Random.Range(0,115);

    if (RandomNumber >= 55)
    {


    }
    else if (RandomNumber  > 10 &&  RandomNumber < 55)
    {



    }
    else
    {
        Debug.Log("10");
    }

















    }




}
