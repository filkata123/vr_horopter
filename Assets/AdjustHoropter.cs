using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustHoropter : MonoBehaviour
{
    [Range(1, 5)]
    public float curveStrength = 1.0f;

    [Range(1, 200)]
    public float dotDensity = 100.0f;

    Material mat;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (mat == null) { Debug.Log("No material found on object."); return; }
        mat.SetFloat("_CurveStrength", curveStrength);
        mat.SetFloat("_DotDensity", dotDensity);
    }

    public void UpdateCurveStrength(float strength)
    {
        curveStrength = strength;
    }

    public void UpdateDotDensity(float density)
    {
        dotDensity = density;
    }
}
