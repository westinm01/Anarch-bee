using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenu;
    public GameObject levelOver;
    public GameObject gameOver;
    public GameObject winScreen;
    public GameObject timer;
    bool levelIsOver = false;

    private void Awake()
    {
        Time.timeScale = 1f;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause(0);
        }
    }
    
    public void Pause(int val)
    {
        if (levelIsOver)
        {
            return;
        }
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
            levelIsOver = true;
            levelOver.SetActive(true);
            Time.timeScale = 0f;
            DeenableControls();
            HideOtherUI();
            break;
            case 2: //gameOver menu
            levelIsOver = true;
            gameOver.SetActive(true);
            Time.timeScale = 0f;
            DeenableControls();
            HideOtherUI();
            break;
            case 3: //win menu
            levelIsOver = true;
            winScreen.SetActive(true);
            Time.timeScale = 0f;
            DeenableControls();
            FindObjectOfType<ScoreBreakdown>().BreakdownScore();
            HideOtherUI();
            break;
        }
        
    }

    private void HideOtherUI()
    {
        timer.SetActive(false);
    }

    private void DeenableControls()
    {
        FindObjectOfType<Paddle>().enabled = false;
        FindObjectOfType<BallLauncher>().enabled = false;

    }

    public void setGameIsPaused(bool val)
    {
        gameIsPaused = val;
    }

}
