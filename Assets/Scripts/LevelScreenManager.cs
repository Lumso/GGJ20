using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScreenManager : MonoBehaviour
{
    private int statusUpdate;
    private int levelUpdate;
    private Animator buttonAnimator;

    void Start()
    {
        buttonAnimator = this.GetComponent<Animator>();
    }

    public void StartAnim(string animName)
    {
        buttonAnimator.Play(animName);
    }

    public void SetGameStatusNum(int statusNum)
    {
        statusUpdate = statusNum;
    }

    public void SetLevelNum(int levelNum)
    {
        levelUpdate = levelNum;
    }


    public void ChangeGameStatus()
    {
        GameManager._GAME_MANAGER.UpdateGameStatus(statusUpdate);
        this.gameObject.SetActive(false);
    }

    public void ChangeGameLevel()
    {
        GameManager._GAME_MANAGER.UpdatePlayerRole(levelUpdate);
    }
}
