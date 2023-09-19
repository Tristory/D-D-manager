using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterH : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public int spriteIndex;

    /*void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = transform.parent.GetComponent<CSpriteManager>().head;
    }*/

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        FindNumber(spriteRenderer.sprite.name);
    }

    void FindNumber(string sName)
    {
        foreach(Char i in sName)
        {
            if(Char.IsDigit(i))
            {
                spriteIndex = Int32.Parse(i.ToString());
            }    
        }

        /*for (int i = 0; i < sName.Length; i++) 
        {
            if(isdigit(sName[i]))
                spriteIndex = Int32.Parse(sName[i].ToString());
        }*/
    }

    public void GetSpriteName()
    {
        //spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        FindNumber(spriteRenderer.sprite.name);
        Debug.Log(spriteIndex);
    }
}
