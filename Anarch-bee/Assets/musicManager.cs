using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class musicManager : MonoBehaviour
{
    int currentScene;
    [SerializeField] GameObject queenMusic;
    [SerializeField] GameObject regularMusic;

    // Update is called once per frame
    void Update()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        if(currentScene == 7)
        {
            regularMusic.SetActive(false);
            queenMusic.SetActive(true);
        }
    }
}
