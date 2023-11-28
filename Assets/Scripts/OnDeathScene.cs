using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnDeathScene : MonoBehaviour
{
    public void Start()
    {
        Scene current = SceneManager.GetSceneByBuildIndex(1);
        SceneManager.SetActiveScene(current);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadRetry()
    {
        SceneManager.LoadScene(2);
    }
}

