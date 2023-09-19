using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexGenerator : MonoBehaviour
{
    [SerializeField]
    public int _width, _height;

    [SerializeField]
    private GameObject _hex;

    [SerializeField]
    private Transform _cam;

    private Dictionary<Vector2, GameObject> _hexs;

    // Start is called before the first frame update
    void Start()
    {
        HexSpawn();
    }

    void HexSpawn()
    {
        _hexs = new Dictionary<Vector2, GameObject>();

        int myWidth;

        /*for(int x = 0; x < _width; x++)
        {
            for(int y = 0; y < _height; y++)
            {
                float xPos = (float) x * 0.8659766f;
                float yPos = (float) y * 0.75f;

                if(y % 2 == 0)
                {
                    xPos += 0.4329884f;
                }

                var spawnedHex = Instantiate(_hex);
                spawnedHex.name = $"Tile {x} {y}";
                spawnedHex.transform.position = new Vector3(xPos, yPos, 0);

                var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);

                //spawnedHex.Init(isOffset);

                _hexs[new Vector2(x, y)] = spawnedHex;
            }
        }*/

        for(int y = 0; y < _height; y++)
        {
            if(y % 2 == 0)
            {
                myWidth = _width;
            }
            else
            {
                myWidth = _width + 1;
            }

            for(int x = 0; x < myWidth; x++)
            {
                float xPos = (float) x * 0.8659766f;
                float yPos = (float) y * 0.75f;

                if(y % 2 == 0)
                {
                    xPos += 0.4329884f;
                }

                var spawnedHex = Instantiate(_hex);
                spawnedHex.name = $"Tile {x} {y}";
                spawnedHex.transform.position = new Vector3(xPos, yPos, 0);

                var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);

                //spawnedHex.Init(isOffset);

                _hexs[new Vector2(x, y)] = spawnedHex;
            }
        }

        _cam.transform.position = new Vector3((float)_width/2 - 0.5f, (float)_height/2 - 0.5f, -10);
    }
}
