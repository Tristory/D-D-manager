using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpawner : MonoBehaviour
{
    public GameObject test_Tile;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newText = Instantiate(test_Tile);
    }
}
