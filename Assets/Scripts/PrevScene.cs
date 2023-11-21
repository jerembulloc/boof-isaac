using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrevScene : MonoBehaviour
{
    private int SceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        SceneToLoad = SceneManager.GetActiveScene().buildIndex - 1;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D colission)
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}

