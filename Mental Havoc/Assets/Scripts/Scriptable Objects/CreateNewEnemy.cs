using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]
public class CreateNewEnemy : ScriptableObject
{
    //Crea un tipo de enemigo, es facil solamente tenes que dar click derecho en alguna carpeta, ir a crear y despues enemy
    public new string name;
    public float speed;
    public float damage;
    public int health;

    public Sprite sprite;


    

}
