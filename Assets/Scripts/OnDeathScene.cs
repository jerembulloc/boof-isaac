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
		// reset powerups
		GameController.MoveSpeed = 6.0f;
		GameController.FireRate = 0.5f;
		GameController.BulletSize = 0.5f;
		GameController.BulletSpeed = 7.5f;

        SceneManager.LoadScene(0);
    }

    public void LoadRetry()
    {
		// reset powerups
		GameController.MoveSpeed = 6.0f;
		GameController.FireRate = 0.5f;
		GameController.BulletSize = 0.5f;
		GameController.BulletSpeed = 7.5f;
		
        SceneManager.LoadScene(2);
    }
}

