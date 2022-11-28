using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartTimer : MonoBehaviour
{
    private float timeLeft;
    public TextMeshProUGUI startText;
    public static int flag_start = 0;
    public GameObject layerOpaco;
    
    // Start is called before the first frame update
    void Start()
    {
        startText = GetComponent<TextMeshProUGUI>();
        timeLeft = 3.4f;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = timeLeft.ToString("0");
        if (timeLeft < 1)
        {
            //startText.text = "Start!";
            //Thread.Sleep(1000);
            gameObject.SetActive(false);
            flag_start = 1;
            layerOpaco.SetActive(false);

        }
    }
}
