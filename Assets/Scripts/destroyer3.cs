using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class destroyer3 : MonoBehaviour
{
    public static bool destruction3 = false;
    private void OnTriggerEnter2D(Collider2D col)
    {
        //LIVELLO3: associare la FORMA
        if (col.gameObject.name == "House1") //forma: RETTANGOLO
        {
            if ((gameObject.name == "Giftrect-blue(Clone)")||
                (gameObject.name == "Giftrect-red(Clone)")||
                (gameObject.name == "Giftrect-yellow(Clone)")||
                (gameObject.name == "Giftrect-green(Clone)"))
            {
                TextScript.score += 1;
                ShowFinalScore.finalscore += 1; 
            }
        }
        
        if (col.gameObject.name == "House2") //forma: CARTA
        {
            if ((gameObject.name == "Gifthouse-blue(Clone)")||
                (gameObject.name == "Gifthouse-red(Clone)")||
                (gameObject.name == "Gifthouse-yellow(Clone)")||
                (gameObject.name == "Gifthouse-green(Clone)"))            {
                TextScript.score += 1;
                ShowFinalScore.finalscore += 1; 
            }
        }
        
        if (col.gameObject.name == "House3")//forma: CUBO
        {
            if((gameObject.name == "Giftbox-blue(Clone)")||
               (gameObject.name == "Giftbox-red(Clone)")||
               (gameObject.name == "Giftbox-yellow(Clone)")||
               (gameObject.name == "Giftbox-green(Clone)"))
            {
                TextScript.score += 1;
                ShowFinalScore.finalscore += 1; 
            }
        }
        
        if (col.gameObject.name == "House4")//forma: CALZA
        {
            if ((gameObject.name == "Giftsock-blue(Clone)")||
                (gameObject.name == "Giftsock-red(Clone)")||
                (gameObject.name == "Giftsock-yellow(Clone)")||
                (gameObject.name == "Giftsock-green(Clone)"))
            {
                TextScript.score += 1;
                ShowFinalScore.finalscore += 1; 
            }
        }
        
        Destroy(gameObject);
        destruction3 = true; 
    }
}
