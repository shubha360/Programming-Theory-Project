using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cylinder : Shape
{
    private void Awake()
    {
        base.ShapeName = "Cylinder";
        base.VolumeFormula = "π * radius^2";
        base.SurfaceFormula = "2 * π * r * h + 2 * π * r^2";
        base.ShapeColor = "Purple";
    }

    // POLYMORPHISM
    protected override void RotateShape()
    {
        ShapeRb.AddTorque(Vector3.right, ForceMode.Impulse);
    }
}