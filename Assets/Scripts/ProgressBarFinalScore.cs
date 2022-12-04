using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[ExecuteInEditMode()]
public class ProgressBarFinalScore : MonoBehaviour
{
    
    public Image mask;
    private float reactiontimeneutral;
    private float reactiontimecongruent;
    private float reactiontimeincongruent;
    private float count;
    
    
  
    // Start is called before the first frame update
    void Start()
    {
        mask.fillAmount = 1.0f;
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
    void Update(){
         reactiontimeneutral = FinalLevelScores.timelevel0 / (count * 10.0f);
        //reaction time % over total time for congruent and incongruent levels, with weighted sum for level 2 and 3
        //to make level 3 count more (higher difficulty)
        reactiontimecongruent = FinalLevelScores.timelevel1 / (count*10.0f); 
        reactiontimeincongruent = (FinalLevelScores.timelevel2*0.4f + FinalLevelScores.timelevel3*0.6f) / ( count * 10.0f);
    
        if(gameObject.name == "TimeCongruent") {
            mask.fillAmount = 1.0f-(float)reactiontimecongruent;
        }
        else if (gameObject.name == "TimeIncongruent") {
            mask.fillAmount = 1.0f-(float)reactiontimeincongruent;
        }

    }


}

