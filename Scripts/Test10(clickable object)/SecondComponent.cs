using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondComponent : MonoBehaviour
{
    public ClickableObject clicky;
    
    void Start()
    {
        //Get ClickableObject component of the current object
        clicky = GetComponent<ClickableObject>();

        Debug.Log("Hey: " + clicky.someNumber);
    }
}
