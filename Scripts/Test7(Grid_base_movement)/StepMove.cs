using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepMove : MonoBehaviour
{
    public float reference;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
            transform.Translate(0, reference, 0);
        else if(Input.GetKeyDown(KeyCode.DownArrow))
            transform.Translate(0, -reference, 0);
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
            transform.Translate(-reference, 0, 0);
        else if(Input.GetKeyDown(KeyCode.RightArrow))
            transform.Translate(reference, 0, 0);
    }
}
