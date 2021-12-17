using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawn_freq = 0.5f; 
    public GameObject[] foods; //array of food sprites
    public GameObject spawner; //this
    public float spawn_range = 3f; //how far from spawner can food spawn
    public int numFoods; //number of foods to throw
    private int randomTimeFactor; //time after each food drop

    void Start()
    {
        //
        numFoods = 6;
        StartCoroutine("SpeedScaler");
    }

    void Update()
    {

    }

    IEnumerator SpeedScaler()
    {
        for (; ; )
        {
            randomTimeFactor = Random.Range(0, 5);
            spawnBlock();
            yield return new WaitForSeconds(randomTimeFactor * spawn_freq);
        }

    }

    void spawnBlock()
    {
        float randomNumber = Random.Range(-spawn_range, spawn_range);
        int randomFood = Random.Range(0, numFoods);


        Instantiate(
            foods[randomFood], new Vector3(
            this.transform.position.x + randomNumber, this.transform.position.y, this.transform.position.z), 
            Quaternion.identity);

    }
}