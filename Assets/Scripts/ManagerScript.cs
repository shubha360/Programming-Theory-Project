using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject TitleScreen;
    [SerializeField] private GameObject ShapesScreen;

    [SerializeField] private TMP_InputField NameInputField;
    [SerializeField] private TextMeshProUGUI NameText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FromTitleToShapes()
    {
        NameText.text = $"Hi {NameInputField.text}";

        TitleScreen.SetActive(false);
        ShapesScreen.SetActive(true);
    }
}
