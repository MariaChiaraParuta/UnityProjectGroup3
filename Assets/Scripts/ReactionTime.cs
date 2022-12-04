using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ReactionTime : MonoBehaviour
{
    public TextMeshProUGUI reactiontime;


    public static float reactiontimeincongruent;
    private float count;
    // Start is called before the first frame update
    void Start()
    {
        reactiontime = GetComponent<TextMeshProUGUI>();
        //reactiontime.text = 100 + "%";
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

        //reaction time % over total time for congruent and incongruent levels, with weighted sum for level 2 and 3
        //to make level 3 count more (higher difficulty)

        reactiontimeincongruent = (FinalLevelScores.timelevel2*0.4f + FinalLevelScores.timelevel3*0.6f) / ( count * 10.0f);
        reactiontime.text = (int)(100 * (1-(reactiontimeincongruent))) + "%";
    }
}
