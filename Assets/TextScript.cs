using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
public class TextScript : MonoBehaviour {
 
 
 
    public TextMeshProUGUI scoreText;
    public static int score;
 
 
    // Use this for initialization
    void Start ()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        score = 0;
        scoreText.text = "Score: "+score;
 
    }
 
 
    // Update is called once per frame
    void Update()
    {
        //score += 1;
        scoreText.text = "Score: " + score;
 
    }


}
