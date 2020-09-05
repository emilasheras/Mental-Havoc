using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody2D rb;
    Vector2 movedown;
    

    void Update()
    {
        movedown.y = -speed;

    }
    private void FixedUpdate() 
    {
     rb.MovePosition(rb.position + movedown * speed * Time.deltaTime);  
    }
}
