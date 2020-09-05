using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject BulletPrefab;
    Vector3 vectorsito;
    private void Start()
    {
    
    vectorsito = new Vector3( 0,1,0);

    StartCoroutine(ExampleCoroutine());

    }

    //corrutina para esperar
    IEnumerator ExampleCoroutine()

    {

       yield return new WaitForSeconds(2);

        Shoot();
        Start();
    }
    //spawnea la bala "Bullet"
    void Shoot()
    {
        
        Instantiate (BulletPrefab, FirePoint.position+vectorsito, FirePoint.rotation);
        
    }
}
