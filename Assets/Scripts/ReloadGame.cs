using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadGame : MonoBehaviour
{
    public void ReloadGameScene(string scene_name)
    {
        Debug.Log("Game reloaded");
        SceneManager.LoadScene(scene_name);
    }
}
