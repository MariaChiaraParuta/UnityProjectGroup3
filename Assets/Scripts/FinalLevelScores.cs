using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

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
    // Start is called before the first frame update
    void Start()
    {
        finalscore = GetComponent<TextMeshProUGUI>();

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
