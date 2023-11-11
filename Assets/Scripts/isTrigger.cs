using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            print("works");
        }
    }
}
