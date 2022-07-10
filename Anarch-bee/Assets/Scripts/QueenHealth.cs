using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QueenHealth : MonoBehaviour
{
    [SerializeField]
    private QueenBoss queen;
    Vector3 scaleVals;
    private int health;
    private int currentHealth;
    private float currentXScale;

    [SerializeField]
    private Color fullColor;
    [SerializeField]
    private Color halfwayColor;
    [SerializeField]
    private Color quarterColor;
    // Start is called before the first frame update
    void Start()
    {
        health = queen.health;
        currentXScale = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        scaleVals = transform.localScale;
        currentHealth = queen.currentHealth;
        float healthRatio = (float)currentHealth / (float)health;
        transform.localScale = new Vector3(healthRatio * currentXScale, transform.localScale.y, transform.localScale.z);
        if(healthRatio > 0.5f)
        {
            GetComponent<Image>().color = fullColor;
        }
        else if(healthRatio > 0.25f)
        {
            GetComponent<Image>().color = halfwayColor;
        }
        else{
            GetComponent<Image>().color = quarterColor;
        }
    }

}
