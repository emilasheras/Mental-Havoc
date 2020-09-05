using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   public float speed = 20f;
   public Rigidbody2D rb;

   private void Start()
   {

   rb.velocity = transform.up * speed;
   Destroy (gameObject, 3);
   
   }

   
}
