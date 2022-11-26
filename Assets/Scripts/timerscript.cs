using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class timerscript : MonoBehaviour
{
  public float count = 5.0f;
  // public int seconds;
  public TextMeshProUGUI counttext;

  private bool drop;
  private bool isspawn;

  public static float secNeeded;

  void Start()
  {
    counttext = GetComponent<TextMeshProUGUI>();
    secNeeded = 0.0f;
  }

  void Update()
  {
    if (StartTimer.flag_start == 1)
    {
      drop = false;
      isspawn = false;

      if (GameObject.Find("Giftcard(Clone)") || GameObject.Find("Giftbox(Clone)")
                                             || GameObject.Find("Giftrect(Clone)") ||
                                             GameObject.Find("Giftsock(Clone)"))
      {
        isspawn = true;
      }

      if (Input.GetKey(KeyCode.DownArrow))
      {
        drop = true;
      }

      if (count >= 0 && drop == false && isspawn == true)
      {
        secNeeded += Time.deltaTime;
        count -= Time.deltaTime;
        counttext.text = "" + count.ToString("0");
      }
      else if (drop == true && count >= 0)
      {
        count = 5.2f;
        counttext.text = "" + count.ToString("0");
        isspawn = false;
      }
      else if (count <= 0)
      {
        count = 5;
        counttext.text = "" + count.ToString("0");
        isspawn = false;
      }
    }
  }
  
}
