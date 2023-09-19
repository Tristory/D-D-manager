using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public GameObject selectedObject;
    public ClickableObject clicker;

    void Update()
    {
        Vector3 mousePosition  = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(Input.GetMouseButtonDown(0))
        {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);
            if(targetObject)
            {
                selectedObject = targetObject.transform.gameObject;

                clicker = targetObject.GetComponent<ClickableObject>();

                //Debug.Log(clicker.GetType().ToString());
            }
        }
    }
}
