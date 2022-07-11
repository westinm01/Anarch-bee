using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{
    public int currentTime;
    private float delta = 0;

    public PauseGame gameCanvasPauseGame;
    
    //[SerializeField]
    private TextMeshProUGUI timerText;

    private InventoryManager iterator;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        currentTime = int.Parse(timerText.text);
        iterator = FindObjectOfType<InventoryManager>();
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
                if(iterator.GetRemainingBees() > 9)
                {
                    gameCanvasPauseGame.Pause(1);
                }
                else{
                    gameCanvasPauseGame.Pause(2);
                }
                
                
            }
            
        }
    }

    public int GetTime()
    {
        return currentTime;
    }
}
