using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[ExecuteInEditMode()]
public class ProgressBarFinalScore : MonoBehaviour
{
    
    public Image mask;
    
    
  
    // Start is called before the first frame update
    void Start()
    {
        mask.fillAmount = 0.0f;

    }

    // Update is called once per frame
    void Update(){
    
    if(gameObject.name == "TimeCongruent") {
        mask.fillAmount = 1-FinalLevelScores.reactiontimecongruent;
    }
    else if (gameObject.name == "TimeIncongruent") {
        mask.fillAmount = 1-FinalLevelScores.reactiontimeincongruent;
    }
    //  masklevel1.fillAmount = (FinalLevelScores.scorelevel1)/10.0f;
       //masklevel2.fillAmount = (FinalLevelScores.scorelevel2)/10.0f;
       //masklevel3.fillAmount = (FinalLevelScores.scorelevel3)/10.0f;
       //maskreactiontimeC.fillAmount = FinalLevelScores.reactiontimecongruent;
       //maskreactiontimeINC.fillAmount = FinalLevelScores.reactiontimeincongruent;
    }


}

