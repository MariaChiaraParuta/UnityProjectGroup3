using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class destroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        TextScript.score += 1;        
        Destroy(gameObject);
    }
}
