using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerActivator : MonoBehaviour
{
    public GameObject Spawner;
    public GameObject Button;
    public void ActiveGameObject()
    {
        StartCoroutine(SpawnerSetActive());

    }
    IEnumerator SpawnerSetActive()
    {
        yield return new WaitForSeconds(3);
        Spawner.SetActive(true);
        Button.SetActive(true);
        Debug.Log("holis");
    }
}
