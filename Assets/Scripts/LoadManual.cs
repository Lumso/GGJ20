using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadManual : MonoBehaviour
{
    public GameObject Level1Parent;
    public GameObject Level2Parent;


    void Start()
    {
        if (GameManager._GAME_MANAGER._selectedLevel == GameManager.SelectedLevel.Level_1)
        {
            Level1Parent.SetActive(true);
            Level2Parent.SetActive(false);
        }
        else if (GameManager._GAME_MANAGER._selectedLevel == GameManager.SelectedLevel.Level_2)
        {
            Level1Parent.SetActive(false);
            Level2Parent.SetActive(true);
        }
    }
}
