using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SOMaker : MonoBehaviour
{
    public void MakingSO()
    {
        //Create folder
        //AssetDatabase.CreateFolder("Assets/ScriptableObject/Test22", "SOFolder");

        //Create Scriptable object
        SimpleSave simpleSave = new SimpleSave();
        AssetDatabase.CreateAsset(simpleSave, "Assets/ScriptableObject/Test22/SOFolder/firstSave.asset");
        //AssetDatabase.SaveAsset();
    }
}
