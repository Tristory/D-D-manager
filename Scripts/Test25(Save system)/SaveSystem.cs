using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePlayer(Ayer ayer)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = "Assets/Save"/* Can be replace with Application.persistentDataPath*/ + "/player.fun";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(ayer);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData LoadPlayer()
    {
        string path = "Assets/Save" + "/player.fun";

        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;            
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
