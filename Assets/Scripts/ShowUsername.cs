using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShowUsername : MonoBehaviour
{
    public TextMeshProUGUI name_text;
    public string user;


    // Start is called before the first frame update
    void Start()
    {
        name_text = GetComponent<TextMeshProUGUI>();
        user = PlayerPrefs.GetString("username");
    }

    // Update is called once per frame
    void Update()
    {
        name_text.text = "Hello, " + user + "!";
           
    }
}
