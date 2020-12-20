using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator anim;
    Vector2 movement;

private void Update() 
{
   movement.x = Input.GetAxisRaw("Horizontal");
   movement.y = Input.GetAxisRaw("Vertical");
   //animations();
}

void FixedUpdate()
{
    rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
}
}