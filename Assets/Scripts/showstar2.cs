using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showstar2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        if (TextScript.score >= 6)
        {
            gameObject.SetActive(true);
        }
    }
    
}
