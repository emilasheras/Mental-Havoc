using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject BulletPrefab;


    private void Update()
    {


     if (Input.touchCount > 0)

     {
        
         Debug.Log(Input.touchCount);

     }



    }
    void Shoot()
    {
        
        Instantiate (BulletPrefab, FirePoint.position, FirePoint.rotation);

    }
}
