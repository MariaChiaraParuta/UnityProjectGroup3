using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;

public class RandomSpawner : MonoBehaviour
{
    public GameObject[] gifts;
    public Vector3 delta;
    public float TimeBetweenSpawn;
    public float timeFromSpawn;
    public int instantiationnumber;

    //-->Parent.transform.position+delta
    public GameObject Parent;
    public GameObject InstantiatedGift;

    private Rigidbody2D rb;

    private void Awake()
    {

        timeFromSpawn = TimeBetweenSpawn;
        instantiationnumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (instantiationnumber > 10)
        {
            SceneManager.LoadScene("ScoreLevel2"); // dopo 10 oggetti finisce il livello
        }
        
        if (timeFromSpawn <= 0)
        {
            if (instantiationnumber > 0)
            {
                Destroy(InstantiatedGift);
            }

            int rand = Random.Range(0, 15);
            Parent = GameObject.Find("Sleigh");
            InstantiatedGift = Instantiate(gifts[rand], Parent.transform.position + delta, Quaternion.identity);
            InstantiatedGift.transform.parent = Parent.transform;
            timeFromSpawn = TimeBetweenSpawn;
            instantiationnumber += 1;
        }
        else
        {
            timeFromSpawn -= Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow) && instantiationnumber>0)
        {
            InstantiatedGift.transform.parent = null;
            InstantiatedGift.GetComponent<Rigidbody2D>().gravityScale = 1;
            InstantiatedGift.GetComponent<BoxCollider2D>();
        }
    }
}

    
