using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]
public class CreateNewEnemy : ScriptableObject
{
    
    public new string name;
    public float speed;
    public float damage;
    public int health;

    public Sprite sprite;




}
