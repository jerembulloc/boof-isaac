using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBuff : MonoBehaviour
{
    public int amount;
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Player") {

            int currentHP = GameController.HP;
            if (currentHP + amount >= 6)
            {
                GameController.HP = 6;
            }
            else
            {
                GameController.HP += amount;
            }

            gameObject.SetActive(false);
        }


    }
}
