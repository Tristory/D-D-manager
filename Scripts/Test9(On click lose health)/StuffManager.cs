using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuffManager : MonoBehaviour
{
    public GameObject theThingy;
    public Stuff theStuff;

    // Start is called before the first frame update
    void Start()
    {
        theThingy  = GameObject.FindWithTag("Stuff");
        if(theThingy != null)
            theStuff = theThingy.GetComponent<Stuff>();
    }

    // Update is called once per frame
    void Update()
    {
        if(theStuff.HP > 0)
        {
            if(Input.GetKeyDown(KeyCode.Mouse0))
            {
                theStuff.HP -= 1;
            }
        }
        else
        {
            theStuff.Destroy();
        }
        
    }
}
