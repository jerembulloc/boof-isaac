using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	// with static these exist and are accessible pretty much everywhere
	public static GameController instance;

	private static int hp = 6;

	private static int maxHP = 6;

	private static float moveSpeed = 1.0f;

	private static float fireRate = 1.0f;


	// get and set functions
	public static int HP { 
		get => hp; 
		set => hp = value; 
	}

	public static int MaxHP { 
		get => maxHP; 
		set => maxHP = value; 
	}

	public static float MoveSpeed { 
		get => moveSpeed; 
		set => moveSpeed = value; 
	}

	public static float FireRate { 
		get => fireRate; 
		set => fireRate = value; 
	}

    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null) {
			instance = this;
		}
    }

    // Update is called once per frame
    void Update()
    {
		// ----------------- Test code ---------------------
        /*int randomNum = Random.Range(0,10);

		if (randomNum == 7) {
			DamagePlayer();
		}

		if (randomNum == 3 || randomNum == 4) {
			HealPlayer();
		}*/
		// --------------------------------------------------
    }

	// To damage the player call GameController.DamagePlayer(); from anywhere.
	// HealPlayer works the same way.
	public static void DamagePlayer() {
		hp =- 1;
	}

	public static void HealPlayer() {
		hp += 1;
	}


	// kill player?
	// public static void kill(){}
}
