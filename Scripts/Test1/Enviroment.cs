using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enviroment : Event
{
    public string Rainning()
    {
        description = "The rain is pouring down.";
        return description;
    }

    public string Shinning()
    {
        description = "The sun is shining hard.";
        return description;
    }
}
