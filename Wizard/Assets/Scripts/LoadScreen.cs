using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public void SceneLoader()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if(currentScene == 2)
        {
            currentScene = -1;
        }
        SceneManager.LoadScene(currentScene + 1);
    }
}
