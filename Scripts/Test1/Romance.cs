using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Romance : Event
{
    public string Romance_1(string targetA, string targetB)
    {
        description = targetA + " and " + targetB + " got closer as a human being.";
        return description;
    }

    public string Romance_2(string targetA, string targetB)
    {
        description = targetA + " and " + targetB + " found each other attractive.";
        return description;
    }

    public string Romance_3(string targetA, string targetB)
    {
        description = targetA + " and " + targetB + " felt irresistabale for each other.";
        return description;
    }
}
