using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{
    public void Start()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(currentLevel);
    }
    public void ScreenLoader(string sceneString)
    {
       SceneManager.LoadScene(sceneString);
    }
    public void LoadNextLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentLevel + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
