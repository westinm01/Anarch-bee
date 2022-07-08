using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeSpin : MonoBehaviour
{
    bool collided = false;
    Rigidbody2D myRB;
    float spinDirection = 1;

    private void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collided = true;
        spinDirection = Mathf.Sign(UnityEngine.Random.Range(-1f, 1f));
    }

    private void Update()
    {
        if (collided)
        {
            float x = Mathf.Abs(myRB.velocity.x);
            float y = Mathf.Abs(myRB.velocity.y);

            // wow pythagorean theorem knowledge B]
            float averageVelocity = Mathf.Sqrt(x * x + y * y);
            
            transform.eulerAngles += new Vector3(0f, 0f, Mathf.Clamp(averageVelocity, 0f, 6f) * spinDirection);
        }
    }
}
