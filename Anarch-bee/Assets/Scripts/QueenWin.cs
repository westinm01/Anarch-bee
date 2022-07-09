using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenWin : MonoBehaviour
{
    // Start is called before the first frame update
    public QueenBoss queen;
    
    void Update()
    {
        if(queen.health<=0)
        {
            GetComponent<PauseGame>().Pause(3);
        }
    }
}
