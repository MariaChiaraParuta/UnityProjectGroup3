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
        mask.fillAmount = 1.0f;

    }

    // Update is called once per frame
    void Update(){
    
        if(gameObject.name == "TimeCongruent") {
            mask.fillAmount = 1.0f-(float)FinalLevelScores.reactiontimecongruent;
        }
        else if (gameObject.name == "TimeIncongruent") {
            mask.fillAmount = 1.0f-(float)FinalLevelScores.reactiontimeincongruent;
        }

    }


}

