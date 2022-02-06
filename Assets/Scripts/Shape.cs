using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{   
    private string ShapeName { get; set; }
    private string VolumeFormula { get; set; }
    private string SurfaceFormula { get; set; }

    protected virtual void DisplayInfo()
    {

    }
}
