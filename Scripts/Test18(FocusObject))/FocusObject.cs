using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusObject : MonoBehaviour
{
    public int focusValue;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<Bill>() != null)
        {
            other.GetComponent<Bill>().focusObjects.Add(this);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.GetComponent<Bill>() != null)
        {
            other.GetComponent<Bill>().focusObjects.Remove(this);
        }
    }
}
