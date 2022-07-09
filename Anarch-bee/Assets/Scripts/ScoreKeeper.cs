using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] int beeValue = 100;
    [SerializeField] int blockValue = 75;
    [SerializeField] int secondValue = 75;
    int score = 0;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void addBlockScore()
    {
        score += blockValue;
    }

    public void addBeeScore()
    {
        score += GetComponent<InventoryManager>().GetRemainingBees() * beeValue;
    }

    public void addTimeScore()
    {
        score += FindObjectOfType<Countdown>().GetTime() * secondValue;
    }

    public void resetScore()
    {
        score = 0;
    }
}
