using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickMovement : MonoBehaviour
{
       public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Joystick joystick;

   private void Update() 
{
    if (joystick.Horizontal >= .2f)
    {

   movement.x = moveSpeed;
        
    }
    else if (joystick.Horizontal <= -.2f)
    
    {
        movement.x = -moveSpeed;
    }
    else
    {
        movement.x = 0f;
    }



    
}

void FixedUpdate()
{
    
    rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

}
}
