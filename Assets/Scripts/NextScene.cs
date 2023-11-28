using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{

    private int nextSceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D colission)
    {
        if (colission.tag == "Player")
        {
            SceneManager.LoadScene(nextSceneToLoad);
            print(SceneManager.GetActiveScene().buildIndex);
        }
            
    }
}
