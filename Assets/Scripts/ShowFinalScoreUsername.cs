using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShowFinalScoreUsername : MonoBehaviour
{
    public string user;
    public TextMeshProUGUI textUsername;
    // Start is called before the first frame update
    void Start()
    {
        textUsername = GetComponent<TextMeshProUGUI>();
        user = PlayerPrefs.GetString("username");
    }

    // Update is called once per frame
    void Update()
    {
        textUsername.text = "Well done, " + user + "!!!";
    }
}
