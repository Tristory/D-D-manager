using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FocusBoard : MonoBehaviour
{
    public FocusObject focusObject;
    public TextMeshProUGUI focusText;

    void Start()
    {
        TextUpdate();
    }

    void TextUpdate()
    {
        focusText.text = $"{focusObject.focusValue}";
    }

    public void IncreaseFocusValue()
    {
        focusObject.focusValue += 10;
        TextUpdate();
    }
}
