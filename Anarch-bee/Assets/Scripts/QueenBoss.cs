using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenBoss : MonoBehaviour
{
    public int health = 30;
    public int currentHealth = 30;
    private float colorTimer = 0;
    [SerializeField]
    private Color damageColor;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
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
        currentHealth--;
        GetComponent<SpriteRenderer>().color = damageColor;
        Debug.Log("Hit!");
        colorTimer = 0.1f;
    }
}
