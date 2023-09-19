using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stuff : MonoBehaviour
{
    public int HP;

    public void Destroy()
    {
        this.gameObject.SetActive(false);
    }

    public bool BeingDead()
    {
        HP -= 2;

        if(HP <= 0)
        {
            Destroy();
            return true;
        }
        else
            return false;
    }
}
