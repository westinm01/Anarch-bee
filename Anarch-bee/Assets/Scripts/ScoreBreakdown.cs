using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBreakdown : MonoBehaviour
{
    [SerializeField] TMP_Text timePointText;
    [SerializeField] TMP_Text beePointText;
    [SerializeField] TMP_Text newTotalText;
    InventoryManager inventory;
    ScoreKeeper scoreKeeper;
    Countdown countdown;

    // Start is called before the first frame update
    void Awake()
    {
        inventory = FindObjectOfType<InventoryManager>();
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        countdown = FindObjectOfType<Countdown>();
    }

    public void BreakdownScore()
    {
        FindObjectOfType<ScoreKeeper>().addBeeScore();
        FindObjectOfType<ScoreKeeper>().addTimeScore();
        timePointText.text = "Time Points: " + countdown.GetTime() + " seconds x 100pts";
        beePointText.text = "Bee Points: " + inventory.GetRemainingBees() + " bees x 100pts";
        newTotalText.text = "New Total: " + scoreKeeper.GetTotalPoints();
    }
}
