using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class destroyer2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        //LIVELLO2: associare il COLORE
        if (col.gameObject.name == "House1") //colore: BLUE
        {
            if ((gameObject.name == "Giftrect-blue(Clone)")||
                (gameObject.name == "Gifthouse-blue(Clone)")||
                (gameObject.name == "Giftsock-blue(Clone)")||
                (gameObject.name == "Giftbox-blue(Clone)"))
            {
                TextScript.score += 1;
            }
        }
        
        if (col.gameObject.name == "House2") //colore: ROSSO
        {
            if ((gameObject.name == "Giftrect-red(Clone)")||
                (gameObject.name == "Gifthouse-red(Clone)")||
                (gameObject.name == "Giftsock-red(Clone)")||
                (gameObject.name == "Giftbox-red(Clone)"))
            {
                TextScript.score += 1;
            }
        }
        
        if (col.gameObject.name == "House3")// colore: VERDE
        {
            if ((gameObject.name == "Giftrect-green(Clone)")||
                (gameObject.name == "Gifthouse-green(Clone)")||
                (gameObject.name == "Giftsock-green(Clone)")||
                (gameObject.name == "Giftbox-green(Clone)"))
            {
                TextScript.score += 1;
            }
        }
        
        if (col.gameObject.name == "House4")//colore: GIALLO
        {
            if ((gameObject.name == "Giftrect-yellow(Clone)")||
                (gameObject.name == "Gifthouse-yellow(Clone)")||
                (gameObject.name == "Giftsock-yellow(Clone)")||
                (gameObject.name == "Giftbox-yellow(Clone)"))
            {
                TextScript.score += 1;
            }
        }
        
        Destroy(gameObject);
    }
}
