using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class CSpriteManager : MonoBehaviour
{
    public List<Sprite> heads;

    public SpriteRenderer head;
    public SpriteRenderer body;
    public SpriteRenderer left_Leg;
    public SpriteRenderer right_leg;

    public Color color;

    public void UpdateSprite(int headN)
    {
        head.sprite = heads[headN];
        body.color = color;
        left_Leg.color = color;
        right_leg.color = color;
    }
}
