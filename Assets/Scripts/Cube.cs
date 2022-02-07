using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : Shape
{
    private void Awake()
    {
        base.ShapeName = "Cube";
        base.VolumeFormula = "side ^ 3";
        base.SurfaceFormula = "side * 6";
        base.ShapeColor = "Pink";
    }

    // POLYMORPHISM
    protected override void RotateShape()
    {
        ShapeRb.AddTorque(Vector3.back, ForceMode.Impulse);
    }
}
