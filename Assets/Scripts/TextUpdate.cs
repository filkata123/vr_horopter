using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextUpdate : MonoBehaviour
{
    TMP_Text tmp;
    void Start()
    {
        tmp = GetComponent<TMP_Text>();
    }

    // Update text displayed under frame rates slider to showcase frames and Hz
    public void UpdateTextToSliderValue(float value)
    {
        tmp.text = value.ToString() + " frames / " + ((1.0f/Time.smoothDeltaTime) / value).ToString("0") + " Hz";
    }
}
