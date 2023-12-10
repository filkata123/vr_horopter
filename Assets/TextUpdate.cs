using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextUpdate : MonoBehaviour
{
    TMP_Text tmp;
    // Start is called before the first frame update
    void Start()
    {
        tmp = GetComponent<TMP_Text>();
    }

    public void UpdateTextToSliderValue(float value)
    {
        tmp.text = value.ToString();
    }
}
