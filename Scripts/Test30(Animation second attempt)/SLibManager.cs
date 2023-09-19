using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class SLibManager : MonoBehaviour
{
    public Sprite test;

    public SpriteLibrary spriteLibrary => GetComponent<UnityEngine.U2D.Animation.SpriteLibrary>();

    public void OnEnable()
    {
        spriteLibrary.AddOverride(test, "Heads", "1");
    }
}
