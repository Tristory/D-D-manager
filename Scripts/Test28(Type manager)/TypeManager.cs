using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TypeManager : MonoBehaviour
{
    public string typeOfComponent;

    void Start()
    {
        TypeGetter();
    }

    public void TypeGetter()
    {
        //Turn string to type
        Type type = Type.GetType(typeOfComponent);

        //Add component
        gameObject.AddComponent(type);
    }
}
