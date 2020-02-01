using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject UITitle;
    public GameObject UIRole;
    public GameObject UILevel;

    #region ATTEMPT_AT_SINGLETON
    public static GameManager _GAME_MANAGER;
    #endregion

    public enum PlayerRole
    {
        Riparatore,
        Robot,
        None
    }

    public enum SelectedLevel
    {
        Level_1,
        Level_2,
        None
    }

    public enum GameStatus
    {
        InTitle,
        InSelectionLevel,
        InSelectionRole,
        InGame
    }

    public PlayerRole _playerRole;
    public SelectedLevel _selectedLevel;
    public GameStatus _gameStatus;


    private void Awake()
    {
        _GAME_MANAGER = this;

        _gameStatus = GameStatus.InTitle;
        _selectedLevel = SelectedLevel.None;
        _playerRole = PlayerRole.None;

        UITitle.SetActive(true);
        UIRole.SetActive(false);
        UILevel.SetActive(false);
    }


    public void UpdateGameStatus(int status)
    {
        _gameStatus = (GameStatus)status;
    }


    public void UpdatePlayerRole(int role)
    {
        _playerRole = (PlayerRole)role;
    }


    public void UpdateSelectedLevel(int level)
    {
        _selectedLevel = (SelectedLevel)level;
    }
}
