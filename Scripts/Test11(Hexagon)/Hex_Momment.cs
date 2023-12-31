using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hex_Momment : MonoBehaviour
{
    private Vector2 velocity;
    private Vector3 direction;
    private bool hasMoved;
    
    void Update()
    {
        if(velocity.x == 0)
        {
            hasMoved = false;
        }
        else if(velocity.x != 0 && !hasMoved)
        {
            hasMoved = true;
            MoveByDirection();
        }

        velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    private void MoveByDirection()
    {
        if(velocity.x < 0)
        {
            if(velocity.y > 0)
            {
                direction = new Vector3(-0.5f, 0.5f);
            }
            else if(velocity.y < 0)
            {
                direction = new Vector3(-0.5f, -0.5f);
            }
            else
            {
                direction = new Vector3(-1, 0);
            }
        }
        else if(velocity.x > 0)
        {
            if(velocity.y > 0)
            {
                direction = new Vector3(0.5f, 0.5f);
            }
            else if(velocity.y < 0)
            {
                direction = new Vector3(0.5f, -0.5f);
            }
            else
            {
                direction = new Vector3(1, 0);
            }
        }

        transform.position += direction;
    }
}
