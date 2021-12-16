using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawn_freq = 1f;
    public GameObject[] foods; //array of food sprites
    public GameObject spawner; //this
    public float spawn_range = 3f; //how far from spawner can food spawn
    private int numFoods; //number of foods to throw

    void Start()
    {
        StartCoroutine("SpeedScaler");
        numFoods = 6;
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
        int randomFood = Random.Range(0, numFoods - 1);

        Instantiate(
            foods[randomFood], new Vector3(
            spawner.transform.position.x + randomNumber, spawner.transform.position.y, spawner.transform.position.z), 
            Quaternion.identity);

    }
}