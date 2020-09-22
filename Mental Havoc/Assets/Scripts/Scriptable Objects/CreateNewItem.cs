using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class CreateNewItem : ScriptableObject
{
   
   //crea un item con estos valores
    public float Damage;
    public float Critical;
    public int Health;
    public int DropChance;

    public Sprite sprite;
    

}
