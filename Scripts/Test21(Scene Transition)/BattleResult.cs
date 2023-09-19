using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleResult : MonoBehaviour
{
    public string sceneName;
    /*void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            LoadNormal();
        }
    }*/

    public void LoadNormal()
    {
        SceneManager.LoadScene(sceneName);
    }
}
