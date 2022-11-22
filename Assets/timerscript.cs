using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class timerscript : MonoBehaviour
{
  public float count = 10.0f;
  // public int seconds;
  public TextMeshProUGUI counttext;

  private bool drop;
  private float spawnNow;

  void Start()
  {
    counttext = GetComponent<TextMeshProUGUI>();
  }

  void Update()
  {
    drop = false;

    if (Input.GetKey(KeyCode.DownArrow))
    {
      drop = true;
    }

    if (count >= 0 && drop == false)
    {
      count -= Time.deltaTime;
      counttext.text = "Time: " + count.ToString("0");
    }
    else if(drop == true && count >= 0)
    {
      count = 10;
    }
    else if (count <= 0)
    {
      count = 10;
    }
  }
  
}
