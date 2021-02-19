using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseMute : MonoBehaviour
{
    public AudioSource audioSource;
    void Start()
    {
        audioSource.Play();
        audioSource.volume = 0f;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" )
        {
            audioSource.volume = 0f;
            NoisePlay.isTrigger = false;
        }
    }
}
