using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroyer1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "House1")
        {
            if (gameObject.name == "Giftrect-blue(Clone)")
            {
                TextScript.score += 1;
            }
        }
        
        if (col.gameObject.name == "House2")
        {
            if (gameObject.name == "Gifthouse-red(Clone)")
            {
                TextScript.score += 1;
            }
        }
        
        if (col.gameObject.name == "House3")
        {
            if (gameObject.name == "Giftbox-green(Clone)")
            {
                TextScript.score += 1;
            }
        }
        
        if (col.gameObject.name == "House4")
        {
            if (gameObject.name == "Giftsock-yellow(Clone)")
            {
                TextScript.score += 1;
            }
        }
        
        Destroy(gameObject);
    }
}
