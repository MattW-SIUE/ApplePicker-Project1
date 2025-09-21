using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOVer : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("START");
        SceneManager.LoadScene("_Scene_0");
    }

    public void MainMenu()
    {
        Debug.Log("QuitToMenu");
        SceneManager.LoadScene("StartMenu");
    }
}
