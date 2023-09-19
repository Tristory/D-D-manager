using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionBlock : MonoBehaviour
{
    //public GameObject parent;

    public Skill currentSkill;

    //public Vector3 currentPos;

    //public Vector3 localPos;

    public Collider2D _target;

    public bool _hovered, _collided;

    void Start()
    {
        //parent = transform.parent.gameObject;

        currentSkill = transform.parent.GetComponent<Skill>();

        //currentPos = transform.position;

        //localPos = transform.localPosition;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(_hovered)
            {
                CallAction();
            }            
        }
    }

    void OnMouseEnter()
    {
        _hovered = true;
    }

    void OnMouseExit()
    {
        _hovered = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            _collided = true;
            _target = other;
        }        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        _collided = false;
    }

    void CallAction()
    {
        /*if(currentSkill.GetType() == typeof(Movement))
        {
            parent.GetComponent<Movement>().MoveTo(transform.localPosition);
        }
        else if(currentSkill.GetType() == typeof(Attack))
        {
            parent.GetComponent<Attack>().AttackAt(_target);
        }*/

        currentSkill.Test(transform.localPosition, _target);
        
        Destroy(currentSkill.gameObject);
    }
}
