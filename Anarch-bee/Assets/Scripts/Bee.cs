using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnColliderEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "honeyComb")
        {
            Destroy(collision.gameObject); //might destroy the entire tilemap...
        }
    }
}
