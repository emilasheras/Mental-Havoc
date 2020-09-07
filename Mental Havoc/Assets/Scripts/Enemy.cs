using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody2D rb;
    Vector2 movedown;
    
    public int health = 2;


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
