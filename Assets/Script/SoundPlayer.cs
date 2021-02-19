using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public static float audioVol = 1.0f;
    void Start()
    {
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = audioVol;
    }

  
}
