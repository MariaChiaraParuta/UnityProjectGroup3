using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[ExecuteInEditMode()]
public class ProgressBar : MonoBehaviour
{
    private int maximum = 10;
    private int current;
    public Image mask;
  
    // Start is called before the first frame update
    void Start()
    {
        current = 0;
    }

    // Update is called once per frame
    void Update()
    {
        current = RandomSpawner.instantiationnumber;
        GetCurrentFill();
    }

    void GetCurrentFill()
    {
        float fillamount = (float)current / (float)maximum;
        mask.fillAmount = fillamount;
        

    }
}
