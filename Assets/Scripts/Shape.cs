using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(Rigidbody))]
public abstract class Shape : MonoBehaviour
{
    protected Rigidbody ShapeRb;

    private void Start()
    {
        ShapeRb = GetComponent<Rigidbody>();

        ShapeRb.useGravity = false;
    }

    protected string ShapeName;
    protected string VolumeFormula;
    protected string SurfaceFormula;

    // ENCAPSULATION
    private string backingColor = "WATER";
    protected string ShapeColor
    {
        get
        {
            return backingColor;
        }

        set
        {
            if (!value.Equals("Pink") &&
                !value.Equals("Orange") &&
                !value.Equals("Purple"))
            {
                Debug.LogError("Shape color should be Pink, Orange, or Purple.");
            } 
            else
            {
                backingColor = value;
            }
        }
    }

    [SerializeField] protected TextMeshProUGUI infoText;

    // ABSTRACTION
    protected void DisplayInfo()
    {
        infoText.gameObject.SetActive(true);
        infoText.text =
            $"{ShapeName.ToUpper()}\n" +
            $"Volume: {VolumeFormula}\n" +
            $"Surface: {SurfaceFormula}\n" +
            $"\n" +
            $"This {ShapeName.ToLower()} is {ShapeColor.ToLower()}";
    }

    // ABSTRACTION
    private void OnMouseDown()
    {
        RotateShape();
        DisplayInfo();
    }

    protected abstract void RotateShape();
}
