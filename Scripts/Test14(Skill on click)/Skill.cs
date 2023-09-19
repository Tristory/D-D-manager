using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    public GameObject parent;
    public BattleTurnManager turnM;

    void Start()
    {
        parent = transform.parent.gameObject;

        turnM = GameObject.FindWithTag("TurnManager").GetComponent<BattleTurnManager>();
    }

    public virtual void Test (Vector3 translation, Collider2D target)
    {
        //Debug.Log("This text from skill.");

        turnM.TurnEnd();
    }
}
