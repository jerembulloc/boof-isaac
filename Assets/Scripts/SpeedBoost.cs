using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBuff : MonoBehaviour
{
    public float amount;
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Player") {

            var speed = GameController.MoveSpeed;
            {
                GameController.MoveSpeed += amount;
            }

            gameObject.SetActive(false);
        }


    }
}
