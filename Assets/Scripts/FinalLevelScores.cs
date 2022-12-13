using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.IO;

public class FinalLevelScores : MonoBehaviour
{
    public static int scorelevel0;
    public static int scorelevel1;
    public static int scorelevel2;
    public static int scorelevel3;
    public static float timelevel0;
    public static float timelevel1;
    public static float timelevel2;
    public static float timelevel3;
    public TextMeshProUGUI finalscore;
    //private float count;
    //private float reactiontimeneutral;
    //public static float reactiontimecongruent;
    //public static float reactiontimeincongruent;


    private float scoreaverage;

    void CreateText(){
     //path of the file --> Assets
     string path = Application.dataPath + "/Log.txt";
     //create if it doesn't exist
     if(!File.Exists(path)){
       File.WriteAllText(path, "Christmas delivery Stats\nUsername,Age, Level, Level0, TimeLevel0,Level1, TimeLevel1,Level2, TimeLevel2,Level3, TimeLevel3\n");
      }
     //username, age, difficulty, level0, timelevel0, level1, timelevel1, level2, timelevel2,level3, timelevel3, final score
     string content = PlayerPrefs.GetString("username")+","+
                     PlayerPrefs.GetInt("age")+","+
                     SliderValue.level + ","+
                     scorelevel0 + "," + timelevel0 + "," +
                     scorelevel1 + "," + timelevel1 + "," +
                     scorelevel2 + "," + timelevel2 + "," +
                     scorelevel3 + "," + timelevel3 + "\n" ;
     File.AppendAllText(path,content);            
    }
 
    // Start is called before the first frame update
    void Start()
    {
        finalscore = GetComponent<TextMeshProUGUI>();
        CreateText();
    }

    // Update is called once per frame
    void Update()
    {


        finalscore.text = "Level 0: " + scorelevel0 +" in "+timelevel0+" seconds\n"+
                                      "Level 1: " + scorelevel1+" in "+timelevel1+" seconds\n"+
                                      "Level 2: " + scorelevel2 +" in "+timelevel2+" seconds\n"+
                                      "Level 3: " + scorelevel3+" in "+timelevel3+" seconds\n"+
                                      "Congruent level: "+ReactionTime1.reactiontimecongruent+
                                       "\nIncongruent level: "+ReactionTime.reactiontimeincongruent;
    }
}
