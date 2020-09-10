using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float EnemyDamage;
    
    public int health;

    public SpriteRenderer mysprite;
    public CreateNewEnemy EnemyType;
    

    public Rigidbody2D rb;
    Vector2 movedown;

    private void Start()
    {

    speed = EnemyType.speed;
    mysprite.sprite = EnemyType.sprite;
    health = EnemyType.health;
    EnemyDamage = EnemyType.damage;


    }

    void Update()
    {
        movedown.y = -speed;

    }
    private void FixedUpdate() 
    {

     rb.MovePosition(rb.position + movedown * speed * Time.deltaTime);  

    }
    public void TakeDamange (int Damage)
    {
        health -= Damage;

        if (health <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        Destroy(gameObject);
        
    }

}
