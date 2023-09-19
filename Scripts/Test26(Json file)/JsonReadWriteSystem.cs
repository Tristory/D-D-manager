using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class JsonReadWriteSystem : MonoBehaviour
{
    public int level;
    public int health;
    public Tester1_model tester1_Model;
    public List<int> intList;

    public void SaveToJson()
    {
        SaveModel data = new SaveModel();
        data.level = level;
        data.health = health;
        data.tester1_Model = tester1_Model;
        data.intList = intList;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.dataPath + "/savemodel.json", json);
    }

    public void LoadFromJson()
    {
        string json = File.ReadAllText(Application.dataPath + "/savemodel.json");
        SaveModel data = JsonUtility.FromJson<SaveModel>(json);

        level = data.level;
        health = data.health;
        tester1_Model = data.tester1_Model;
        intList = data.intList;
    }
}
