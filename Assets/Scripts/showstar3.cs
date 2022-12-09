using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showstar3 : MonoBehaviour
{
    private int timeok;
    // Start is called before the first frame update
    void Start()
        {
            gameObject.SetActive(false);
            if (SliderValue.level == 1)
            {
                timeok = 48;
            }
            else if (SliderValue.level == 2)
            {
                timeok = 36;
            }
            else if (SliderValue.level == 3)
            {
                timeok = 24;
            }
            
            if (TextScript.score >= 8 && timerscript.secNeeded < timeok)
            {
                gameObject.SetActive(true);
            }
            else if (TextScript.score == 10)
            {
                gameObject.SetActive(true);
            }
        }
}
