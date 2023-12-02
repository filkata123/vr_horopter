using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchEyeRenderVariable: MonoBehaviour
{
    public float frameNum = 10;

    Material mat;
    bool renderLeftEye = true; // renders left eye if true, right eye if false

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (mat == null) { Debug.Log("No material found on object."); return; }

        // Each frameNum frames change on which eye the object is rendered
        if (Time.frameCount % frameNum == 0)
        {
            ChangeEye();
        }
    }

    void ChangeEye()
    {
        // Each frameNum frames change on which eye the object is rendered
        mat.SetInt("_RenderLeftEye", Convert.ToInt32(renderLeftEye));

        renderLeftEye = !renderLeftEye;
    }

    public void SetFrameNum(float frames)
    {
        frameNum = frames;
    }
}