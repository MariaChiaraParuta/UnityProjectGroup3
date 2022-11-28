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
    public static int instantiationnumber = 0;
    private bool flag_down_arrow=false;
    //-->Parent.transform.position+delta
    public GameObject Parent;
    public GameObject InstantiatedGift;

    private Rigidbody2D rb;

    private void Awake()
    {
        timeFromSpawn = 4;
        instantiationnumber = 0;
        if (SliderValue.level == 1) //livello facile
        {
            TimeBetweenSpawn = 8.0f;
        }
        else if (SliderValue.level == 2)//livello medio
        {
            TimeBetweenSpawn = 6.0f;
        }
        else if(SliderValue.level == 3)//livello difficile
        {
            TimeBetweenSpawn = 4.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (instantiationnumber > 10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1); // dopo 10 oggetti finisce il livello
        }
        
        if ((timeFromSpawn <= 0) || 
            (destroyer0.destruction0 == true)|| 
            (destroyer1.destruction1 == true)||
            (destroyer2.destruction2 == true)||
            (destroyer3.destruction3 == true)
            )
        {
            //the gift wasn't destroyed by the collision
            if ((instantiationnumber > 0) && 
                    (
                        (destroyer0.destruction0 == false)||
                        (destroyer1.destruction1 == false)||
                        (destroyer2.destruction2 == false)||
                        (destroyer3.destruction3 == false)
                    )
                ) 
            {
                Destroy(InstantiatedGift);
            }
            destroyer0.destruction0 = false;
            destroyer1.destruction1 = false;
            destroyer2.destruction2 = false;
            destroyer3.destruction3 = false;
            
            int rand = Random.Range(0, gifts.Length);
            Parent = GameObject.Find("Sleigh");
            InstantiatedGift = Instantiate(gifts[rand], Parent.transform.position + delta, Quaternion.identity);
            InstantiatedGift.transform.parent = Parent.transform;
            timeFromSpawn = TimeBetweenSpawn;
            instantiationnumber += 1;
            flag_down_arrow = false;
        }
        else
        {
            timeFromSpawn -= Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow) && instantiationnumber>0 && flag_down_arrow==false)
        {
            InstantiatedGift.transform.parent = null;
            InstantiatedGift.GetComponent<Rigidbody2D>().gravityScale = 1;
            InstantiatedGift.GetComponent<BoxCollider2D>();
            flag_down_arrow = true;
            
            //timeFromSpawn = 0;
        }
    }
}

    
