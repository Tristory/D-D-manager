using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeManager : MonoBehaviour
{
    public Act timechange;

    public static int minute { get; private set; }
    public static int hour { get; private set; }

    public float minuteToRealTime;
    private float timer;

    void Start()
    {
        minute = 0;
        hour = 10;
        timer = minuteToRealTime;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            minute++;

            if(minute >= 60)
            {
                hour++;

                minute = 0;
            }

            timechange.Raise();
            timer = minuteToRealTime;
        }
    }
}
