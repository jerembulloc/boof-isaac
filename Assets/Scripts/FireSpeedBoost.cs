using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpeedBoost : MonoBehaviour
{
    public float fireDelayM;
    public float bulletSpeedM;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController playerController = other.GetComponent<PlayerController>();

            if (playerController != null)
            {
                playerController.fireDelay *= fireDelayM;
                playerController.bulletSpeed *= bulletSpeedM;
            }

            gameObject.SetActive(false);
        }
    }
}
