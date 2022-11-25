using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class startlevel2or3 : MonoBehaviour
{
    public float counttime;
    public void Start ()
    {
        counttime = 0.0f;
    }
    
    public void Update()
    {
        // il bottone è attivo solo quando babbo natale finisce di parlare
        counttime += Time.deltaTime;
        if(counttime> 12.0f)
        {
            gameObject.GetComponent<Button>().onClick.AddListener(LoadScene);
        }
    }
    private void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}