using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bill : MonoBehaviour
{
    public int focusPossessed;

    public float speed;
    private Vector3 change;
    private Rigidbody2D _rigidbody2D;
    
    public bool interactiveOn;
    public GameObject metaSense;
    public List<FocusObject> focusObjects = new List<FocusObject>();

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");

        Movement();

        Interact();

        MetaSensing();
    }

    void Movement()
    {
        change.Normalize();
        _rigidbody2D.MovePosition(transform.position + change * speed * Time.deltaTime);
    }
    
    public void Interact()
    {
        if(focusObjects.Count > 0)
        {
            interactiveOn = true;
        }
        else
        {
            interactiveOn = false;
        }
    }

    void MetaSensing()
    {
        if(interactiveOn)
        {
            metaSense.SetActive(true);
        }
        else
        {
            metaSense.SetActive(false);
        }
    }
}
