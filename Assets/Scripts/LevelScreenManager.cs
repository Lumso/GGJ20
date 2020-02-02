using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScreenManager : MonoBehaviour
{
    public GameObject prevUI;

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
    }

    public void ChangeGameLevel()
    {
        GameManager._GAME_MANAGER.UpdateSelectedLevel(levelUpdate);
    }

    public void BackUI(string prevAnim)
    {
        Debug.Log("Va back");
        prevUI.SetActive(true);
        prevUI.GetComponent<Animator>().Play(prevAnim);
        this.gameObject.SetActive(false);
    }

    public void LoadNextScene()
    {
        if (GameManager._GAME_MANAGER._playerRole == GameManager.PlayerRole.Robot) SceneManager.LoadScene("robot");
        else if (GameManager._GAME_MANAGER._playerRole == GameManager.PlayerRole.Riparatore) SceneManager.LoadScene("player");
        else Debug.Log("Scene not defined");
    }
}
