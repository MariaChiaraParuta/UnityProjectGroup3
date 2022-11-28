using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class timerscript : MonoBehaviour
{
  private float count;
  // public int seconds;
  public TextMeshProUGUI counttext;

  private bool drop;
  private bool isspawn;

  public static float secNeeded;

  void Start()
  {
    counttext = GetComponent<TextMeshProUGUI>();
    secNeeded = 0.0f;
    if (SliderValue.level == 1) //livello facile
    {
      count = 8.0f;
    }
    else if (SliderValue.level == 2)//livello medio
    {
      count = 6.0f;
    }
    else if(SliderValue.level == 3)//livello difficile
    {
      count = 4.0f;
    }


  }

  void Update()
  {
    if (StartTimer.flag_start == 1)
    {
      drop = false;
      isspawn = false;

      if (//regali neutri
            GameObject.Find("Giftcard(Clone)") || GameObject.Find("Giftbox(Clone)") || GameObject.Find("Giftrect(Clone)") || GameObject.Find("Giftsock(Clone)") 
          //regali blue
            ||GameObject.Find("Gifthouse-blue(Clone)") || GameObject.Find("Giftbox-blue(Clone)") || GameObject.Find("Giftrect-blue(Clone)") || GameObject.Find("Giftsock-blue(Clone)")
         //regali rossi
            || GameObject.Find("Gifthouse-red(Clone)") || GameObject.Find("Giftbox-red(Clone)") || GameObject.Find("Giftrect-red(Clone)") || GameObject.Find("Giftsock-red(Clone)")
         //regali gialli
            || GameObject.Find("Gifthouse-yellow(Clone)") || GameObject.Find("Giftbox-yellow(Clone)") || GameObject.Find("Giftrect-yellow(Clone)") || GameObject.Find("Giftsock-yellow(Clone)")
         //regali verdi
            || GameObject.Find("Gifthouse-green(Clone)") || GameObject.Find("Giftbox-green(Clone)") || GameObject.Find("Giftrect-green(Clone)") || GameObject.Find("Giftsock-green(Clone)")
         )
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
        if (SliderValue.level == 1) //livello facile
        {
          count = 8.0f+0.2f;
        }
        else if (SliderValue.level == 2)//livello medio
        {
          count = 6.0f+0.2f;
        }
        else if(SliderValue.level == 3)//livello difficile
        {
          count = 4.0f+0.2f;
        }

        counttext.text = "" + count.ToString("0");
        isspawn = false;
      }
      else if (count <= 0)
      {
        if (SliderValue.level == 1) //livello facile
        {
          count = 8.0f;
        }
        else if (SliderValue.level == 2)//livello medio
        {
          count = 6.0f;
        }
        else if(SliderValue.level == 3)//livello difficile
        {
          count = 4.0f;
        }
        counttext.text = "" + count.ToString("0");
        isspawn = false;
      }
    }
  }
  
}
