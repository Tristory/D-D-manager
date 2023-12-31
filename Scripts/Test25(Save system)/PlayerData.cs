using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int level;
    public int health;
    public float[] position;

    public PlayerData(Ayer ayer)
    {
        level = ayer.level;
        health = ayer.health;

        position = new float[3];
        position[0] = ayer.transform.position.x;
        position[1] = ayer.transform.position.y;
        position[2] = ayer.transform.position.z;
    }
}
