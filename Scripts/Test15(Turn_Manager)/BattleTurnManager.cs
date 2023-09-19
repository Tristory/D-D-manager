using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleTurnManager : MonoBehaviour
{
    public List<Monster> monsters = new List<Monster>();

    private int currentN;
    //public BattleResult battleResult;

    public GameObject endResult;

    void Start()
    {
        currentN = 0;

        TurnStart();
    }

    void Update()
    {
        if(monsters.Count == 1)
        {
            BattleEnded();
        }
    }

    public void TurnStart()
    {
        monsters[currentN].inTurn = true;
    }

    public void TurnEnd()
    {
        monsters[currentN].inTurn = false;
        Tracker();
        TurnStart();
    }

    void Tracker()
    {
        if(currentN < monsters.Count - 1)
        {
            currentN += 1;
        }
        else
        {
            currentN = 0;
        }
    }

    void BattleEnded()
    {
        //battleResult.LoadNormal();

        endResult.SetActive(true);
    }
}
