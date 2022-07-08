using System;
using System.Collections;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    [SerializeField] GameObject paddle;

    [SerializeField] float launchSpeed = 8f;
    [SerializeField] float launchDelay = 0.5f;

    Boolean ballLaunched = false;
    Boolean delayOver = true;


    void Update()
    {
        if (!ballLaunched)
        {
            transform.position = new Vector3(paddle.transform.position.x, paddle.transform.position.y + 1f, 0f);
        }

        if((Input.GetKeyDown(KeyCode.B) || Input.GetMouseButtonDown(0)) && delayOver)
        {
            LaunchBall();
            StartCoroutine(DelayNextLaunch());
        }
    }

    private void LaunchBall()
    {
        ballLaunched = true;

        GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-2f, 2f), launchSpeed);
    }

    public bool GetBallLaunched()
    {
        return ballLaunched;
    }

    IEnumerator DelayNextLaunch()
    {
        delayOver = false;
        yield return new WaitForSeconds(launchDelay);
        delayOver = true;
    }
}
