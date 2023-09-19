using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : Skill
{
    public void MoveTo(Vector3 translation)
    {
        parent.transform.Translate(translation);
    }

    public override void Test(Vector3 translation, Collider2D target)
    {
        parent.transform.Translate(translation);
        //Debug.Log("This text from Movement.");

        base.Test(translation, target);
    }
}
