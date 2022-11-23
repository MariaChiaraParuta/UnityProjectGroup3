using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class showscorelevel1 : MonoBehaviour
{
    public TextMeshProUGUI scorelevel1;
    public string user;


    // Start is called before the first frame update
    void Start()
    {
        scorelevel1 = GetComponent<TextMeshProUGUI>();
        user = PlayerPrefs.GetString("username");
    }

    // Update is called once per frame
    void Update()
    {   
        if (TextScript.score == 10)
        {
            scorelevel1.text = user + ", your score is: " + TextScript.score.ToString() + "/10\n\nPerfect! Thanks to you all the kids now have their dream gift for Christmas!!";
        }
        else if (TextScript.score == 8 || TextScript.score == 9)
        {
            scorelevel1.text = user + ", your score is: " + TextScript.score.ToString() + "/10\n\nAmazing job! I wasn't gonna make it without your help, thank you!!";
        }
        else if (TextScript.score > 4 && TextScript.score <=7)
        {
            scorelevel1.text = user + ", your score is: " + TextScript.score.ToString() + "/10\n\nWell done! You've been a good mate!!";
        }
        else if (TextScript.score <= 4)
        {
            scorelevel1.text = user + ", your score is: " + TextScript.score.ToString() + "/10\n\nDon't give up, next time will be better!!";
        }
        
    }
}
