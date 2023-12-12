using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchEyeRender : MonoBehaviour
{
    Material mat;
    bool renderLeftEye = true; // renders left eye if true, right eye if false

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Each frame change on which eye the object is rendered
    void Update()
    {
        if (mat == null) { Debug.Log("No material found on object."); return; }

        mat.SetInt("_RenderLeftEye", Convert.ToInt32(renderLeftEye));

        renderLeftEye = !renderLeftEye;
    }
}
