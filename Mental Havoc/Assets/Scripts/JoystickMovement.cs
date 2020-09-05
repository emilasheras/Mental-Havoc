using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickMovement : MonoBehaviour
{
    //variables uwu
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Joystick joystick;

   private void Update() 
{
    //Movimiento Horizontal
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
    //Movimiento Vertical
    if (joystick.Vertical >= .2f)
    {

   movement.y = moveSpeed;
        
    }
    else if (joystick.Vertical <= -.2f)
    
    {
        movement.y = -moveSpeed;
    }
    else
    {
        movement.y = 0f;
    }

          
 
                          
    
}
//moviemiento con rb
void FixedUpdate()
{
    
    rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

}
}
