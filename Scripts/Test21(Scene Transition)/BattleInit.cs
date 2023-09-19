using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleInit : MonoBehaviour
{
    public string sceneName;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            LoadBattle();
        }
    }

    void LoadBattle()
    {
        SceneManager.LoadScene(sceneName);
    }
}
