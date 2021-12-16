using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjs : MonoBehaviour
{
    float spawn_freq = 1f;
    public GameObject projToSpawn;
   
    void Start()
    {
        StartCoroutine("SpeedScaler");
    }

    void Update()
    {
        
    }

    IEnumerator SpeedScaler()
    {
        for (; ; )
        {
            // execute block of code here
            spawnBlock();
            yield return new WaitForSeconds(spawn_freq);
        }
    }

    void spawnBlock()
    {
        int randomNumber = Random.Range(-3, 4);

        Instantiate(projToSpawn, new Vector3(0 + randomNumber, 5, -2), Quaternion.identity);

    }
}
