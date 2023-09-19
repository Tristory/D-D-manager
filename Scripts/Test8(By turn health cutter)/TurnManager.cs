using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public List<Stuff> stuffs = new  List<Stuff>();

    int currentN;
    
    void Start()
    {
        currentN = 0;

        //Turner();

        StartCoroutine(KillingGame());
    }

    IEnumerator KillingGame()
    {
        Stuff theEnemy = stuffs[CurrentStuffCounter()].GetComponent<Stuff>();

        if(!theEnemy.BeingDead())
        {
            yield return new WaitForSeconds(2f);

            currentN = CurrentStuffCounter();
            StartCoroutine(KillingGame());
        }
        else
            EndTheBattle();
    }

    void Turner()
    {
        if(stuffs[currentN].GetType() == typeof(HealthCutter))
            StartCoroutine(HealthCutterTurn());
        else if(stuffs[currentN].GetType() == typeof(HealthGiver))
            StartCoroutine(HealthGiverTurn());
    }

    IEnumerator HealthCutterTurn()
    {
        HealthGiver theHealer = stuffs[CurrentStuffCounter()].GetComponent<HealthGiver>();

        theHealer.HP -= 2;

        yield return new WaitForSeconds(2f);

        currentN = CurrentStuffCounter();
        Turner();
    }

    IEnumerator HealthGiverTurn()
    {
        HealthGiver theHealer = stuffs[currentN].GetComponent<HealthGiver>();

        theHealer.HP += 2;

        yield return new WaitForSeconds(2f);

        currentN = CurrentStuffCounter();
        Turner();
    }

    int CurrentStuffCounter()
    {
        int newN = 0;

        if(currentN < stuffs.Count - 1)
        {
            newN = currentN + 1;

            return newN;
        }
        else
        {
            return newN;
        }
    }

    void TypeTester()
    {
        int listLenght = stuffs.Count;

        for(int i = 0; i < listLenght; i++)
        {
            //if(stuffs[i].GetType() == typeof(HealthCutter))
                //Debug.Log("This is healthCutter");
            
            Debug.Log(stuffs[i].GetType().ToString());
        }
    }

    void EndTheBattle()
    {}
}
