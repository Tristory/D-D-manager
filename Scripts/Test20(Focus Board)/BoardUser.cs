using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardUser : MonoBehaviour
{
    public Bill bill;
    public GameObject focusBoard;

    void Start()
    {
        //focusBoard = GameObject.FindGameObjectWithTag("FocusBoard");

        bill = GetComponent<Bill>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(bill.focusObjects.Count > 0)
            {
                focusBoard.GetComponent<FocusBoard>().focusObject = bill.focusObjects[0];

                focusBoard.SetActive(true);
            }            
        }
    }
}
