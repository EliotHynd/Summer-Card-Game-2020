using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public string levelToLoad;
    public string winLevel;
    public void LoadNextLevel()
    {

    }

    public void LoadSpecificLevel()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void LoadWin()
    {
        SceneManager.LoadScene(winLevel);
    }
}
