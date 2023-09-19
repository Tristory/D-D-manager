using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class FolderAccessor : MonoBehaviour
{
    public bool folderExist;
    public SimpleSave simpleSave;

    void Start()
    {
        folderExist = AssetDatabase.IsValidFolder("Assets/ScriptableObject/Test22/SOFolder");

        simpleSave = (SimpleSave)AssetDatabase.LoadAssetAtPath("Assets/ScriptableObject/Test22/SOFolder/firstSave.asset", typeof(SimpleSave));
    }
}
