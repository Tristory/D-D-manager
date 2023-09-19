using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetYourParent : MonoBehaviour
{
    public GameObject parent;

    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
