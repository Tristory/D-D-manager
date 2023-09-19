using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;

public class CSMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D ridgidbody;
    private Vector3 change;
    private Animator animator;

    void Start()
    {
        ridgidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        change = Vector3.zero;

        change.x = Input.GetAxis("Horizontal");
        change.y = Input.GetAxis("Vertical");

        if(change != Vector3.zero)
        {
            MoveCharacter();
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }
    }

    void MoveCharacter()
    {
        ridgidbody.MovePosition(transform.position + change*speed*Time.deltaTime);
    }
}
