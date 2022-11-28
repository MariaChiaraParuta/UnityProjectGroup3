using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class destroyer0 : MonoBehaviour
{
    public static bool destruction0 = false;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "House1")
        {
            if (gameObject.name == "Giftrect(Clone)")
            {
                TextScript.score += 1;
                ShowFinalScore.finalscore += 1; 
            }
        }
        
        if (col.gameObject.name == "House2")
        {
            if (gameObject.name == "Giftcard(Clone)")
            {
                TextScript.score += 1;
                ShowFinalScore.finalscore += 1; 
            }
        }
        
        if (col.gameObject.name == "House3")
        {
            if (gameObject.name == "Giftbox(Clone)")
            {
                TextScript.score += 1;
                ShowFinalScore.finalscore += 1; 
            }
        }
        
        if (col.gameObject.name == "House4")
        {
            if (gameObject.name == "Giftsock(Clone)")
            {
                TextScript.score += 1;
                ShowFinalScore.finalscore += 1; 
            }
        }
        
        Destroy(gameObject);
        destruction0 = true;
        
    }
}
