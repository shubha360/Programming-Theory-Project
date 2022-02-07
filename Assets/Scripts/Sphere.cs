using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sphere : Shape
{
    private void Awake()
    {
        base.ShapeName = "Sphere";
        base.VolumeFormula = "4/3 * π * r^2";
        base.SurfaceFormula = "4 * π * r^2";
        base.ShapeColor = "Orange";
    }
    
    // POLYMORPHISM
    protected override void RotateShape()
    {
        ShapeRb.AddTorque(Vector3.forward, ForceMode.Impulse);
    }
}
