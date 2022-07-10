using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenWin : MonoBehaviour
{
    // Start is called before the first frame update
    public QueenBoss queen;
    
    void Update()
    {
        if(queen.currentHealth<=0)
        {
            FindObjectOfType<PauseGame>().Pause(3);
        }
    }
}
