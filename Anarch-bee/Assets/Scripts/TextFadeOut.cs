using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextFadeOut : MonoBehaviour
{
    [SerializeField] float fadeOutAndInTime = 1f;

    bool fadedOut = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !fadedOut)
        {
            StartCoroutine(FadeTextToZeroAlpha(fadeOutAndInTime, GetComponent<TMP_Text>()));
        }
    }
    public IEnumerator FadeTextToZeroAlpha(float t, TMP_Text i)
    {
        fadedOut = true;
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }
    private IEnumerator FadeTextToFullAlpha(float t, TMP_Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
    }

    public void FadeTextIn()
    {
        StartCoroutine(FadeTextToFullAlpha(fadeOutAndInTime, GetComponent<TMP_Text>()));
    }
}
