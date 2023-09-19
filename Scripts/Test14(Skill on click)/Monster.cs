using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public Skill[] skills;

    public bool inTurn;
    public int hitPoint;

    public GameObject currentSkill;
    public BattleTurnManager turnM;

    void Start()
    {
        turnM = transform.parent.GetComponent<BattleTurnManager>();
    }

    void Update()
    {
        if(inTurn)
        {
            SkillManagement();
        }
        

        HealthManagement();
    }

    void SkillManagement()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            UseSkill(0);
        }
        else if(Input.GetKeyDown(KeyCode.Backspace))
        {
            UseSkill(1);
        }
    }

    void UseSkill(int i)
    {
        currentSkill = skills[i].gameObject;
        //Instantiate(currentSkill, new Vector3(0, 0, 0), Quaternion.identity, transform);
        Instantiate(currentSkill, transform);
    }

    void HealthManagement()
    {
        if(hitPoint <= 0)
        {
            turnM.monsters.Remove(this);
            Destroy(this.gameObject);
        }
    }
}
