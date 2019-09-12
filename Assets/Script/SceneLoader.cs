using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    private string scenes;
    public void LoadScene()
    {
        int currentSceneIndex=SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex+1);
    }

    public void LoadStartScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
