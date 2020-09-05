using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   //Variables
   public float speed = 20f;
   public Rigidbody2D rb;

   private void Start()
   {
   //se spawnea y empieza a moverse para arriba.
   rb.velocity = transform.up * speed;
   //se destruye despues de 3seg
   Destroy (gameObject, 3);

   }
   //rotacion cada frame.
   private void Update() 
   {
   transform.Rotate(0, 0, 5);
   }
}
