using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomSpawner : MonoBehaviour
{
    public GameObject[] gifts;
    public Vector3 delta;
    public float startTimeBtwnSpawn;
    public float timeFromSpawn;

    public GameObject Sleigh;
    
    private void Awake()
    {
        timeFromSpawn = startTimeBtwnSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeFromSpawn <= 0)
        {
            int rand = Random.Range(0, gifts.Length);
            Sleigh = GameObject.Find("Sleigh");
            Instantiate(gifts[rand], Sleigh.transform.position+delta, Quaternion.identity);
            timeFromSpawn = startTimeBtwnSpawn;
        }
        else
        {
            timeFromSpawn -= Time.deltaTime;
        }
    }
}