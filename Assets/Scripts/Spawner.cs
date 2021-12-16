using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawn_freq = 1f;
    public GameObject projToSpawn;
    public GameObject spawner;
    public float spawn_range = 3f;


    void Start()
    {
        StartCoroutine("SpeedScaler");
        //spawner = GameObject.FindGameObjectWithTag("Spawner");
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
        float randomNumber = Random.Range(-spawn_range, spawn_range);

        Instantiate(
            projToSpawn, new Vector3(
            spawner.transform.position.x + randomNumber, spawner.transform.position.y, spawner.transform.position.z), 
            Quaternion.identity);

    }
}