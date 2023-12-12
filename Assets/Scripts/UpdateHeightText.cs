using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateHeightText : MonoBehaviour
{
    TMP_Text tmp;
    void Start()
    {
        tmp = GetComponent<TMP_Text>();
    }   

    // Update height displayed next to position slider
    public void UpdateTextToSliderValue(float value)
    {
        tmp.text = (1.2f + value).ToString("0.00") + " m";
    }
}
