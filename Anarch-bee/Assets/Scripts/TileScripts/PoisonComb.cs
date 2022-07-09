using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonComb : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Bee")
        {

            Destroy(collision.gameObject);
            
            //and play sound
        }
    }
}
