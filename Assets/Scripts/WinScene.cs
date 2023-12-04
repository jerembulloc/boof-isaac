using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinScene : MonoBehaviour
{
    public void LoadMenu()
    {
		// reset powerups and health state
		GameController.HP = 6;
		GameController.MoveSpeed = 6.0f;
		GameController.FireRate = 0.5f;
		GameController.BulletSize = 0.5f;
		GameController.BulletSpeed = 7.5f;

        SceneManager.LoadScene(0);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
