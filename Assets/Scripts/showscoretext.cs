using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class showscoretext : MonoBehaviour
{
    public TextMeshProUGUI scorelevel;
    public string user;


    // Start is called before the first frame update
    void Start()
    {
        scorelevel = GetComponent<TextMeshProUGUI>();
        user = PlayerPrefs.GetString("username");
    }

    // Update is called once per frame
    void Update()
    {   
        if (TextScript.score == 10)
        {
            scorelevel.text = "Amazing job! I wasn't gonna make it without your help!!";
        }
        else if (TextScript.score >= 8 && timerscript.secNeeded < 25)
        {
            scorelevel.text = "Amazing job! I wasn't gonna make it without your help!!";
        }
        else if (TextScript.score >= 6)
        {
            scorelevel.text ="Well done! You've been a good mate!!";
        }
        else if (TextScript.score < 6)
        {
            scorelevel.text = "Don't give up, next time will be better!!";
        }
        
    }
}
