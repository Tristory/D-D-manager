using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public int startX;

    public int numberM;

    public GameObject monster;

    public List<GameObject> friendMon, enemyMon;

    // Start is called before the first frame update
    void Start()
    {
        startX = 4;

        friendMon = new List<GameObject>();

        enemyMon = new List<GameObject>();

        InititateSpawning();
    }

    public void InititateSpawning()
    {
        //Player Side
        SetSide(0, friendMon);

        startX = 4;

        SetSide(8, enemyMon);
    }

    public void SetSide(int yPos, List<GameObject> monsters)
    {
        CreateMonster(startX, yPos, monsters);

        for(int i = 1; i < numberM; i++)
        {
            foreach (GameObject tempMon in monsters)
            {
                tempMon.transform.Translate(new Vector3(-1, 0, 0));
            }

            startX += 1;

            CreateMonster(startX, yPos, monsters);
        }
    }

    public void CreateMonster(int xPos, int yPos, List<GameObject> monsters)
    {
        GameObject newMon = Instantiate(monster);

        newMon.transform.position = new Vector3(xPos, yPos, 0);

        monsters.Add(newMon);
    }
}
