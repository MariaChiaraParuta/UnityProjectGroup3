using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class loadexplainlevel1 : MonoBehaviour
{
    public float counttime;

    private int level;
    public void Start ()
    {
        counttime = 0.0f;
        
    }
    
    public void Update()
    {
        // il bottone è attivo solo quando rudolf finisce di parlare
        counttime += Time.deltaTime;
        if(counttime> 20.0f)
        {
            gameObject.GetComponent<Button>().onClick.AddListener(LoadScene);
        }
    }
    private void LoadScene()
    {
        SceneManager.LoadScene("InsertName");
    }
}
