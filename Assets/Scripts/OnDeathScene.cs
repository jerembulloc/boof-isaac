using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnDeathScene : MonoBehaviour
{
    private int retryScene;
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadActive()
    {
        retryScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(retryScene);
    }
}

