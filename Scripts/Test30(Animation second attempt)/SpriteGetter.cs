using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteGetter : MonoBehaviour
{
    SpriteRenderer spriteRenderer => GetComponent<SpriteRenderer>();

    public SpriteStorer spriteStorer => gameObject.GetComponentInParent<SpriteStorer>(true);

    void OnEnable()
    {
        spriteRenderer.sprite = spriteStorer.header;
    }
}
