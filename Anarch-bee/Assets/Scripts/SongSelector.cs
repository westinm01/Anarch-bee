using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongSelector : MonoBehaviour
{
    // Start is called before the first frame update
    public bool startSong = true;
    public AudioSource song1;
    public AudioSource song2;
    void Start()
    {
        if(startSong)
        {
            song1.Play();
        }
        else
        {
            song2.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
