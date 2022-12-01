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
    private float count;
    private float reactiontimeneutral;
    public static float reactiontimecongruent;
    public static float reactiontimeincongruent;


    private float scoreaverage;
    // Start is called before the first frame update
    void Start()
    {
        finalscore = GetComponent<TextMeshProUGUI>();
        if (SliderValue.level == 1) //livello facile
        {
            count = 8.0f;
        }
        else if (SliderValue.level == 2)//livello medio
        {
            count = 6.0f;
        }
        else if(SliderValue.level == 3)//livello difficile
        {
            count = 4.0f;
        }
         
    }

    // Update is called once per frame
    void Update()
    {
       //reaction time for neutral level
        reactiontimeneutral = timelevel0 / (count * 10.0f);
        //reaction time % over total time for congruent and incongruent levels, with weighted sum for level 2 and 3
        //to make level 3 count more (higher difficulty)
        reactiontimecongruent = timelevel1 / (count*10.0f); 
        reactiontimeincongruent = (timelevel2*0.4f + timelevel3*0.6f) / ( count * 10.0f);
        

        finalscore.text = "Level 0: " + scorelevel0 +" in "+timelevel0+" seconds\n"+
                                      "Level 1: " + scorelevel1+" in "+timelevel1+" seconds\n"+
                                      "Level 2: " + scorelevel2 +" in "+timelevel2+" seconds\n"+
                                      "Level 3: " + scorelevel3+" in "+timelevel3+" seconds";
    }
}
