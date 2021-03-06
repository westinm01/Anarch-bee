using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float minLeftPos = -6.889f;
    [SerializeField] float minRightPos = 6.889f;

    [SerializeField] AudioClip paddleSFX;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = new Vector3(Mathf.Clamp(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, minLeftPos, minRightPos),
            transform.position.y, 0f);

        transform.position = mousePosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bee")
        {
            AudioSource.PlayClipAtPoint(paddleSFX, Vector3.zero);
        }
    }
}
