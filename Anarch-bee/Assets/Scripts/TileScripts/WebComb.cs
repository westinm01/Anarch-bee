using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebComb : MonoBehaviour
{
    private List<GameObject> trappedBees = new List<GameObject>();
    private List<float> timers = new List<float>();
    private List<Vector3> beeVelocities = new List<Vector3>();
    public Vector3 releaseVelocity = new Vector3();
    public bool preserveVelocity = false;
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
                    if(i >= timers.Count)
                    {
                        break;
                    }
                }
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Bee")
        {
            //need to store velocity
            if(preserveVelocity)
            {
                Vector3 vel = collision.gameObject.GetComponent<Rigidbody2D>().velocity;
                beeVelocities.Add(vel);
            }
            
            
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0,0,0);
            collision.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
            //now it's stuck!
            trappedBees.Add(collision.gameObject);
            timers.Add(stuckTime);
            //and play sound
        }
    }
    
    void ReleaseBee(int index)
    {
        trappedBees[index].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;;
        if(preserveVelocity)
        {
            trappedBees[index].GetComponent<Rigidbody2D>().velocity = beeVelocities[index]; //currently kind of buggy
            beeVelocities.RemoveAt(index);
        }
        else{
            trappedBees[index].GetComponent<Rigidbody2D>().velocity = releaseVelocity;
        }

        trappedBees.RemoveAt(index);
        timers.RemoveAt(index);
        
    }
}
