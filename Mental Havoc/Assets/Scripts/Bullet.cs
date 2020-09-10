using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   //Variables
   public int damage = 1;
   public int CriticalDamage = 1;
   public int CriticalChance = 10;
   public float speed = 20f;
   public Rigidbody2D rb;
   
   private int RandomNumber;
   private void Start()
   {
   //se spawnea y empieza a moverse para arriba.
   rb.velocity = transform.up * speed;

   RandomNumber = Random.Range(0,100);

   if (RandomNumber <= CriticalChance )
   {
      damage = damage+ CriticalDamage;
   }

   //se destruye despues de 3seg
   Destroy (gameObject, 3);
   }
   //rotacion cada frame.
   private void Update() 
   {
   transform.Rotate(0, 0, 5);
   }

   void OnTriggerEnter2D(Collider2D hitInfo) 
   {
     Enemy enemy = hitInfo.GetComponent<Enemy>();
      if (enemy != null)
      {

         enemy.TakeDamange(damage);

      }

      Destroy(gameObject);
   }

}
