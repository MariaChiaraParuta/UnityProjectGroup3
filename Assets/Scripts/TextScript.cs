using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TextScript : MonoBehaviour {
 
 
 
    public TextMeshProUGUI scoreText;
    public static int score;
    private string scene_name; 
 
 
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
        
        scoreText.text = "Score: " + score;
        scene_name = SceneManager.GetActiveScene().name;
        if (scene_name == "Level0"){
            FinalLevelScores.scorelevel0 = score;
            FinalLevelScores.timelevel0 = timerscript.secNeeded;
        }
        if (scene_name == "Level1"){
            FinalLevelScores.scorelevel1 = score;
            FinalLevelScores.timelevel1 = timerscript.secNeeded;
        }
        if (scene_name == "Level2"){
            FinalLevelScores.scorelevel2 = score;
            FinalLevelScores.timelevel2 = timerscript.secNeeded;
        }
        if (scene_name == "Level3"){
            FinalLevelScores.scorelevel3 = score;
            FinalLevelScores.timelevel3 = timerscript.secNeeded;
        }

 
    }


}
