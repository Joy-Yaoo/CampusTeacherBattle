using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseStop : MonoBehaviour
{
    public Transform target_player;


    public GameObject boy;
    public GameObject girl;
    public AudioSource music;
    public AudioClip m;


    void Start()
    {
        boy.SetActive(false);
        girl.SetActive(false);
    }



    private void Awake()
    {
      music = gameObject.AddComponent<AudioSource>();
      music.playOnAwake = false;

    }

    void Update()
    {
        if (Input.GetKey("space"))
        {
          music.clip = m;
          music.Play();
            if (Vector2.Distance(transform.position, target_player.position) <= 0.5)
            {
                if (this.tag == "boy")
                {
                    NoisePlay.talking1 = false;

                    boy.SetActive(true);

                    Destroy(this.gameObject);

                }
                if (this.tag == "girl")
                {
                    NoisePlay.talking2 = false;

                    girl.SetActive(true);

                    Destroy(this.gameObject);

                }


            }
        }

    }

}
