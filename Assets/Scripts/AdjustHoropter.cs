using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustHoropter : MonoBehaviour
{
    Material mat;
    float horopterHeight = 1.2f;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
        if (mat == null) { Debug.Log("No material found on object."); return; }
    }

    // Update curve strength based on slider input
    public void UpdateCurveStrength(float strength)
    {
        mat.SetFloat("_CurveStrength", strength);
    }

    // Update dot density based on slider input
    public void UpdateDotDensity(float density)
    {
        mat.SetFloat("_DotDensity", density);
    }

    // Update dot size based on slider input
    public void UpdateDotSize(float size)
    {
        mat.SetFloat("_DotSize", size);
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
