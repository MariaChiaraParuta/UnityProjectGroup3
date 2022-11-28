using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FinalLevelScores : MonoBehaviour
{
    public TextMeshProUGUI finalscore;
    // Start is called before the first frame update
    void Start()
    {
        finalscore = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        finalscore.text = "Level 0: " + ShowFinalScore.totalscore[0] +"\n"+
                                      "Level 1: " + ShowFinalScore.totalscore[1] +"\n"+
                                      "Level 2: " + ShowFinalScore.totalscore[2] +"\n"+
                                      "Level 3: " + ShowFinalScore.totalscore[3];
    }
}
