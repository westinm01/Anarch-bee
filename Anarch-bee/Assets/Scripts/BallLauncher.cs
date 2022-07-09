using System;
using System.Collections;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    [SerializeField] GameObject ball;

    [SerializeField] float launchSpeed = 8f;
    [SerializeField] float launchDelay = 0.5f;

    Boolean ballLaunched = false;
    Boolean delayOver = true;


    void Update()
    {
        // Launch Ball and Begin Delay When Key Pressed
        if((Input.GetKeyDown(KeyCode.B) || Input.GetMouseButtonDown(0)) && delayOver)
        {
            LaunchBall();
            StartCoroutine(DelayNextLaunch());
        }
    }

    // Launches Ball Randomly Upwards
    private void LaunchBall()
    {
        ballLaunched = true;

        GameObject newBall = Instantiate(ball, new Vector3(transform.position.x, transform.position.y + 1f, 0f), Quaternion.identity);

        newBall.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-2f, 2f), launchSpeed);

        InventoryManager iterator = FindObjectOfType<InventoryManager>();
        iterator.subBees(1);
    }

    public bool GetBallLaunched()
    {
        return ballLaunched;
    }

    // Creates a Delay Until the Next Ball Can Be Launched
    IEnumerator DelayNextLaunch()
    {
        delayOver = false;
        yield return new WaitForSeconds(launchDelay);
        delayOver = true;
    }
}
