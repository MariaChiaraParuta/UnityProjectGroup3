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

        //-->Parent.transform.position+delta
    public GameObject Parent; 
    public GameObject InstantiatedGift;
    
 
    
    private void Awake()
    {

        timeFromSpawn = startTimeBtwnSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeFromSpawn <= 0)
        { 
            Destroy(InstantiatedGift);
            
            int rand = Random.Range(0, gifts.Length);
            Parent = GameObject.Find("Sleigh");
            InstantiatedGift = Instantiate(gifts[rand],Parent.transform.position+delta, Quaternion.identity);
            InstantiatedGift.transform.parent = Parent.transform;
            timeFromSpawn = startTimeBtwnSpawn;
        }
        else
        {
            timeFromSpawn -= Time.deltaTime;
        }
        
      
    }
}