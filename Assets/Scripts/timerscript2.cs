using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class timerscript2 : MonoBehaviour
{
  public float count = 5.0f;
  
  // public int seconds;
  public TextMeshProUGUI counttext;
  //public TMP_FontAsset myFont;
  private bool drop;
  private bool isspawn;

  void Start()
  {
    counttext = GetComponent<TextMeshProUGUI>();
    
    //counttext = GetComponent<TMP_FontAsset>();
    //counttext.font = myFont;
  }

  void Update()
  {
    if (StartTimer.flag_start == 1)
    {
      drop = false;
      isspawn = false;

      if (GameObject.Find("Gifthouse-blue(Clone)") || GameObject.Find("Giftbox-blue(Clone)")
                                                   || GameObject.Find("Giftrect-blue(Clone)") ||
                                                   GameObject.Find("Giftsock-blue(Clone)")
                                                   || (GameObject.Find("Gifthouse-red(Clone)") ||
                                                       GameObject.Find("Giftbox-red(Clone)")
                                                       || GameObject.Find("Giftrect-red(Clone)") ||
                                                       GameObject.Find("Giftsock-red(Clone)"))

                                                   || (GameObject.Find("Gifthouse-yellow(Clone)") ||
                                                       GameObject.Find("Giftbox-yellow(Clone)")
                                                       || GameObject.Find("Giftrect-yellow(Clone)") ||
                                                       GameObject.Find("Giftsock-yellow(Clone)"))

                                                   || (GameObject.Find("Gifthouse-green(Clone)") ||
                                                       GameObject.Find("Giftbox-green(Clone)")
                                                       || GameObject.Find("Giftrect-green(Clone)") ||
                                                       GameObject.Find("Giftsock-green(Clone)")))

      {
        isspawn = true;
      }

      if (Input.GetKey(KeyCode.DownArrow))
      {
        drop = true;
      }

      if (count >= 0 && drop == false && isspawn == true)
      {
        count -= Time.deltaTime;
        counttext.text = "" + count.ToString("0");
      }
      else if (drop == true && count >= 0)
      {
        count = 5.0f + 0.2f;
        counttext.text = "" + count.ToString("0");
        isspawn = false;
      }
      else if (count <= 0)
      {
        count = 5.0f;
        counttext.text = "" + count.ToString("0");
        isspawn = false;
      }
    }
  }

}
