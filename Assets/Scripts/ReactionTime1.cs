using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ReactionTime1 : MonoBehaviour
{
    public TextMeshProUGUI reactiontime;

    public static float reactiontimecongruent;

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
        reactiontimecongruent = FinalLevelScores.timelevel1 / (count*10.0f); 
       
        reactiontime.text = (int)(100 * (1-(reactiontimecongruent)))+ "%";
    }
}
