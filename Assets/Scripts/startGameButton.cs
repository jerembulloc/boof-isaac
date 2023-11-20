using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGameButton : MonoBehaviour
{
    public int buildIndex;

    public void StartGame()
    {
        SceneManager.LoadScene(buildIndex);
    }

}