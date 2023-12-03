using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBuff : MonoBehaviour
{
    public float amount;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController playerController = other.GetComponent<PlayerController>();

            if (playerController != null)
            {
                playerController.moveSpeed *= amount;

				// needed for powerups to carry over
				float currentMS = GameController.MoveSpeed;
				GameController.MoveSpeed = currentMS * amount;
            }

            gameObject.SetActive(false);
        }
    }
}
