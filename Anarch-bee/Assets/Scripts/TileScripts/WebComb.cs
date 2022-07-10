using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebComb : MonoBehaviour
{
    private List<GameObject> trappedBees;
    private List<float> timers;
    private List<Vector3> beeVelocities;
    public float stuckTime = 5f;
    private float timePassed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(trappedBees.Count > 0)
        {
            timePassed = Time.deltaTime;
            for (int i = 0; i < timers.Count; i++)
            {
                timers[i] -= timePassed;
                if(timers[i] <= 0)
                {
                    ReleaseBee(i);
                }
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Bee")
        {
            //need to store velocity
            Vector3 vel = collision.gameObject.GetComponent<Rigidbody2D>().velocity;
            beeVelocities.Add(vel);
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0,0,0);
            //now it's stuck!
            trappedBees.Add(collision.gameObject);
            timers.Add(stuckTime);
            //and play sound
        }
    }
    
    void ReleaseBee(int index)
    {
        trappedBees[index].GetComponent<Rigidbody2D>().velocity = beeVelocities[index];
        trappedBees.RemoveAt(index);
        timers.RemoveAt(index);
        beeVelocities.RemoveAt(index);
    }
}
