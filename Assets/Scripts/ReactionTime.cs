using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ReactionTime : MonoBehaviour
{
    public TextMeshProUGUI reactiontime;

    // Start is called before the first frame update
    void Start()
    {
        reactiontime = GetComponent<TextMeshProUGUI>();
 
    }

    // Update is called once per frame
    void Update()
    {
        reactiontime.text = 100 * (1-(int)FinalLevelScores.reactiontimecongruent) + "%";
    }
}
