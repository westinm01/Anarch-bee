using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenu;
    public GameObject levelOver;
    public GameObject gameOver;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause(0);
        }
    }
    
    public void Pause(int val)
    {
        switch(val){
            case 0://pause menu
            gameIsPaused = !gameIsPaused;
            pauseMenu.SetActive(gameIsPaused);
            if(gameIsPaused)
                {
                    Time.timeScale = 0f;
                }
            else 
                {
                    Time.timeScale = 1;
            }
            break;
            case 1://levelOver menu
            levelOver.SetActive(true);
            Time.timeScale = 0f;
            break;
            case 2: //gameOver menu
            gameOver.SetActive(true);
            Time.timeScale = 0f;
            break;
        }
        
    }
    public void setGameIsPaused(bool val)
    {
        gameIsPaused = val;
    }

}
