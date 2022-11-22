using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class startlevel1 : MonoBehaviour
{
    public float secs;
    
    // non va, voglio far apparire il bottone solo quando la renna ha finito di parlare
    
    void Start()
    {
        // gameObject.SetActive(false);
       // secs = 0;
    }

    
    void Update()
    {
        // secs += Time.deltaTime;
        // if( secs > 53.0f)
        // {
           // gameObject.SetActive(true);
            // gameObject.GetComponent<Button>().onClick.AddListener(LoadLevel1);
        
    }

    // private void LoadLevel1()
    // {
       // SceneManager.LoadScene("Level1");
    // }
    
}