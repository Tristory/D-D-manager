using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Act : ScriptableObject
{
    public List<ActivityListener> listeners = new List<ActivityListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i --)
        {
            listeners[i].OnSignalRaised();
        }
    }
    public void RegisterListener(ActivityListener listener)
    {
        listeners.Add(listener);
    }
    public void DeRegisterListener(ActivityListener listener)
    {
        listeners.Remove(listener);
    }
}
