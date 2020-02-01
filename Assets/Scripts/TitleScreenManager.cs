using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreenManager : MonoBehaviour
{
    public GameObject nextUI;

    private int statusUpdate;
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


    public void ChangeGameStatus()
    {
        GameManager._GAME_MANAGER.UpdateGameStatus(statusUpdate);
        nextUI.SetActive(true);
        this.gameObject.SetActive(false);
    }
}