using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustHoropter : MonoBehaviour
{
    [Range(1, 5)]
    public float curveStrength = 1.0f;

    [Range(1, 200)]
    public float dotDensity = 100.0f;

    [Range(0.01f, 1)]
    public float dotSize = 0.2f;

    Material mat;
    float horopterHeight = 1.2f;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    void Update()
    {
        if (mat == null) { Debug.Log("No material found on object."); return; }
        mat.SetFloat("_CurveStrength", curveStrength);
        mat.SetFloat("_DotDensity", dotDensity);
        mat.SetFloat("_DotSize", dotSize);
    }

    // Update curve strength based on slider input
    public void UpdateCurveStrength(float strength)
    {
        curveStrength = strength;
    }

    // Update dot density based on slider input
    public void UpdateDotDensity(float density)
    {
        dotDensity = density;
    }

    // Update dot size based on slider input
    public void UpdateDotSize(float size)
    {
        dotSize = size;
    }

    // Update horopter tilt around x-axis based on slider input
    public void UpdateHoropterTilt(float angle)
    {
        transform.eulerAngles = new Vector3(angle, transform.eulerAngles.y, transform.eulerAngles.z);
    }

    // Update horopter position on y-axis based on slider input
    public void UpdateHoropterPosition(float position)
    {
        transform.position = new Vector3(transform.position.x, horopterHeight + position, transform.position.z);
    }
}
