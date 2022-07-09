using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryManager : MonoBehaviour
{

    int beeNumber = 100;
    [SerializeField] TMP_Text count;

    // Update is called once per frame
    void Update()
    {
        count.text = beeNumber.ToString();
    }

    public void subBees(int amount){
      beeNumber -= amount;
    }

    public int GetRemainingBees()
    {
        return beeNumber;
    }
}
