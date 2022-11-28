using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShowFinalScore : MonoBehaviour
{
    public TextMeshProUGUI finalscoretext;
    public string user;

    public static int finalscore;
    public GameObject stella1;
    public GameObject stella2;
    public GameObject stella3;

    // Start is called before the first frame update
    void Start()
    {
        finalscoretext = GetComponent<TextMeshProUGUI>();
        user = PlayerPrefs.GetString("username");
        stella1.SetActive(true);
        stella2.SetActive(false);
        stella3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {   
        if (finalscore>=30)
        {
            finalscoretext.text = "Amazing job! I wasn't gonna make it without your help!!" + "\nYour final score is: " + finalscore;
            stella3.SetActive(true);
        }
        if (finalscore>18)
        {
            finalscoretext.text = "Well done! You've been a good mate!!"+"\nYour final score is: " + finalscore;
            stella2.SetActive(true);
        }
        else 
        {
            finalscoretext.text ="Don't give up, next time will be better!!"+"\nYour final score is: " + finalscore;
           
        }

        
    }
}
