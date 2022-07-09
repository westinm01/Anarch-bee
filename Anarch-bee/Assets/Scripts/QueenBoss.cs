using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenBoss : MonoBehaviour
{
    public int health = 30;
    private float colorTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (colorTimer >= 0)
        {
            colorTimer -= Time.deltaTime;
        }
        else{
            colorTimer = 0f;
            GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Bee")
        {
            getDamaged();
        }
    }

    public void getDamaged(){
        health--;
        GetComponent<SpriteRenderer>().color = Color.red;
        Debug.Log("Hit!");
        colorTimer = 0.1f;
    }
}