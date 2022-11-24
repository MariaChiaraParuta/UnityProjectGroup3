using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class destroymemenu : MonoBehaviour
{


        private void OnTriggerEnter2D(Collider2D col)
        {
            Destroy(gameObject);
        }

}
