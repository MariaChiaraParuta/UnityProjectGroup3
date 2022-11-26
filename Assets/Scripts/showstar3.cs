using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showstar3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
        {
            gameObject.SetActive(false);
            if (TextScript.score >= 8 && timerscript.secNeeded < 25)
            {
                gameObject.SetActive(true);
            }
            else if (TextScript.score == 10)
            {
                gameObject.SetActive(true);
            }
        }
}
