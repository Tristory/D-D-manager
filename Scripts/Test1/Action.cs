using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : Event
{
    public string actionType;

    public string SelfInflict(string targetA)
    {
        description = targetA + " " + actionType + ".";
        return description;
    }

    public string TargetInflict(string targetA, string targetB)
    {
        description = targetA + " " + actionType + " " + targetB + ".";
        return description;
    }
}
