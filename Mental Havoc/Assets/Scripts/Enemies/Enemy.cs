using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    /*
    Practicamente defino variables
    necesarias para el enemy, tanto
    como el Rb2d como vida,daño,etc.

    */
    public float speed;
    public float EnemyDamage;
    
    public int health;

    public SpriteRenderer mysprite;
    public CreateNewEnemy EnemyType;
    public Progression Progression;
    

    public Rigidbody2D rb;
    Vector2 movedown;

    //Cuando se spawnea el enemy define el valor de las variables,sprite,etc.
    private void Start()
    {
    if (EnemyType == null)
    {
        Debug.Log("Brazil?");
    }
    else 
    {

    speed = EnemyType.speed + Progression.speed;
    EnemyDamage = EnemyType.damage + Progression.damage;
    health = EnemyType.health + Progression.health;

    mysprite.sprite = EnemyType.sprite;
    }

    }
    //Update y Fixedupdate genera el movimiento del enemy
    void Update()
    {
        movedown.y = -speed;

    }
    private void FixedUpdate() 
    {

     rb.MovePosition(rb.position + movedown * speed * Time.deltaTime);  

    }

    //TakeDamage lo que hace es un sistema de vida. Y si se queda en 0 = muere el enemy
    public void TakeDamange (int Damage)
    {
        health -= Damage;

        if (health <= 0)
        {
            Die();
        }

    }
    //es disparado por el condicional de arriba, destruye el enemy
    void Die()
    {
        Destroy(gameObject);
        //evento que dispare loottable
        //100% monedas 20%objeto
        //
    }

}
