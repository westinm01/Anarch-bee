using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{
    public int currentTime;
    private float delta = 0;

    public PauseGame eventSystemPauseGame;
    
    //[SerializeField]
    private TextMeshProUGUI timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        currentTime = int.Parse(timerText.text);
        //timerText.text = startTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(delta >= 1)
        {
            delta = 0;
            currentTime--;
            timerText.text = currentTime.ToString();
            if(currentTime <= 0){
                //call game over
                
                //also call gameOverScreen.
                eventSystemPauseGame.Pause(1);
                
            }
            
        }
    }

    public int GetTime()
    {
        return currentTime;
    }
}
