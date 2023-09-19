using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActivityListener : MonoBehaviour
{
    public Act act;
    public UnityEvent activity;

    public void OnSignalRaised()
    {
        activity.Invoke();
    }

    private void OnEnable()
    {
        act.RegisterListener(this);
    }
    private void OnDisable()
    {
        act.DeRegisterListener(this);
    }
}
