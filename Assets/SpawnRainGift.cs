using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnRainGift : MonoBehaviour
{
    public GameObject[] giftsMenu;
    private GameObject InstantiatedGiftMenu;
    public List<float> possiblePositions;

    public float startTimeBtwnSpawnMenu;
    public float timeFromSpawnMenu;


    private void Awake()
    {
        timeFromSpawnMenu = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeFromSpawnMenu <= 0)
        {
            int rand1 = Random.Range(0, possiblePositions.Count);
            int rand2 = Random.Range(0, giftsMenu.Length);
            InstantiatedGiftMenu=Instantiate(giftsMenu[rand2], new Vector3(possiblePositions.ElementAt(rand1),y:6 ), Quaternion.identity);
            timeFromSpawnMenu = startTimeBtwnSpawnMenu;
            
        }
        else
        {
            timeFromSpawnMenu -= Time.deltaTime;
            
        }


    }
}
