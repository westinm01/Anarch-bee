using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComicScript : MonoBehaviour
{
    [SerializeField] Sprite[] comicPics;
    [SerializeField] AudioClip[] playAudioOnPics;
    //[Header("Shake Screen On Pic")]
    [SerializeField] bool[] shakeScreenOnPics;
    [SerializeField] float shakeIntensity = 10f;
    [SerializeField] float shakeFrequency = 0.5f;
    [SerializeField] float shakeDuration = 0.5f;
    int currentPic = 0;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && (currentPic + 1 < comicPics.Length))
        {
            currentPic++;
            if(shakeScreenOnPics[currentPic]) {
                FindObjectOfType<CinemachineShake>().ShakeCamera(shakeIntensity, shakeFrequency, shakeDuration);
            }
            if(playAudioOnPics[currentPic] != null)
            {
                Camera.main.GetComponent<AudioSource>().PlayOneShot(playAudioOnPics[currentPic]);
            }
            if(currentPic + 1 == comicPics.Length)
            {
                FindObjectOfType<TextFadeOut>().FadeTextIn();
            }
        } else if(Input.GetMouseButtonDown(0) && ((currentPic + 1) == comicPics.Length))
        {
            FindObjectOfType<SceneLoader>().LoadNextScene();
        } 
        GetComponent<SpriteRenderer>().sprite = comicPics[currentPic];

    }
}
