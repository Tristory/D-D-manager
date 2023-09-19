using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeUI : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    void Start()
    {
        timeText = GetComponent<TextMeshProUGUI>();
        UpdateTime();
    }

    public void UpdateTime()
    {
        timeText.text = $"{TimeManager.hour:00}:{TimeManager.minute:00}";
    }
}
