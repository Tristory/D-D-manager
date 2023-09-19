using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionHex : MonoBehaviour
{
    [SerializeField]
    private Color _startC, _selectedC;

    [SerializeField]
    private SpriteRenderer _spriteR;

    public Collider2D _target;

    public bool _hovered, _collided;

    void Start()
    {
        _spriteR = GetComponent<SpriteRenderer>();

        _startC = _spriteR.color;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(_hovered && _collided)
            {
                Destroy(this.gameObject);
            }
        }
    }

    void OnMouseEnter()
    {
        _spriteR.color = _selectedC;

        _hovered = true;
    }

    void OnMouseExit()
    {
        _spriteR.color = _startC;

        _hovered = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        _collided = true;
        _target = other;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        _collided = false;
    }

    public void Interact()
    {}
}
