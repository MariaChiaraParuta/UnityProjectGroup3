using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SliderValue : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _sliderText;
    // Start is called before the first frame update
    void Start()
    {
        _slider.onValueChanged.AddListener((v) =>
        {
            if (v == 1)
            {
                _sliderText.text = "Simple";
            }
            else if (v == 2)
            {
                _sliderText.text = "Medium";
            }
            else if(v==3)
            {
                _sliderText.text = "Difficult";
            }
            else if (v == 0)
            {
                _sliderText.text = " ";
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
