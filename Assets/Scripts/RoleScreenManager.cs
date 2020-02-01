using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleScreenManager : MonoBehaviour
{
    public GameObject nextUI;
    public GameObject prevUI;

    private int statusUpdate;
    private int roleUpdate;
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

    public void SetRoleNum(int roleNum)
    {
        roleUpdate = roleNum;
    }


    public void ChangeGameStatus()
    {
        GameManager._GAME_MANAGER.UpdateGameStatus(statusUpdate);
        nextUI.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void ChangeGameRole()
    {
        GameManager._GAME_MANAGER.UpdatePlayerRole(roleUpdate);
    }


    public void BackUI(string prevAnim)
    {
        prevUI.SetActive(true);
        prevUI.GetComponent<Animator>().Play(prevAnim);
        this.gameObject.SetActive(false);
    }
}
