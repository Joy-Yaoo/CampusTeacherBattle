using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instruction5 : MonoBehaviour
{
    public Image img;
    public GameObject myButton;

    public static bool playerEnter5 = false;
    public AudioSource music;
    public AudioClip m;


    void Start()
    {
        myButton.SetActive(false);
        img.enabled = false;
    }

    private void Awake()
    {
      music = gameObject.AddComponent<AudioSource>();
      music.playOnAwake = false;

    }


    void Update()
    {
        if (playerEnter5 == true)
        {
            img.enabled = false;
            myButton.SetActive(false);
            music.Stop();

        }
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            music.clip = m;
            music.Play();

            img.enabled = true;
            myButton.SetActive(true);
        }
    }
}
