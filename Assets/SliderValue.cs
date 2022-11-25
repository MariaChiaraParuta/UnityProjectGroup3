using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SliderValue : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _sliderText;

    public static int level;
    // Start is called before the first frame update
    void Start()
    {
        _slider.onValueChanged.AddListener((v) =>
        {
            if (v == 1)
            {
                _sliderText.text = "Simple";
                level = 1;
            }
            else if (v == 2)
            {
                _sliderText.text = "Medium";
                level = 2;
            }
            else if(v==3)
            {
                _sliderText.text = "Difficult";
            }
            else if (v == 0)
            {
                _sliderText.text = " ";
                level = 3;
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
