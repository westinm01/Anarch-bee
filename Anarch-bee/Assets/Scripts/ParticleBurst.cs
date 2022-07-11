using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleBurst : MonoBehaviour
{
    [SerializeField] float timeToExpand = 1f;
    float startValue = 0f;
    float endValue = 1f;
    float valueToLerp;


    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(startValue, startValue, 1f);
        StartCoroutine(ExpandScaleOverTime());
        StartCoroutine(DelayDestroy(timeToExpand));
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(valueToLerp, valueToLerp, 1f);
    }

    IEnumerator ExpandScaleOverTime()
    {
        float timeElapsed = 0;
        while (timeElapsed < timeToExpand)
        {
            valueToLerp = Mathf.Lerp(startValue, endValue, timeElapsed / timeToExpand);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        valueToLerp = endValue;
    }
    IEnumerator DelayDestroy(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Destroy(gameObject);
    }
}
