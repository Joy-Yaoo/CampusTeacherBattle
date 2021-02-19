using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollect : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public static int ballNum = 0;

    public static bool isTrigger = false;

    private Transform target;
    public AudioSource music;
    public AudioClip m;



    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        if (Playground.playerEnter == true)
        {
            rb = this.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(-speed, 0);
        }

    }
    private void Awake()
    {
      music = gameObject.AddComponent<AudioSource>();
      music.playOnAwake = false;

    }

    void Update()
    {
        if (Playground.playerEnter == true)
        {
            rb = this.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(-speed, 0);
        }


        if (Input.GetKey("space"))
        {
          music.clip = m;
          music.Play();

            if (Vector2.Distance(transform.position, target.position) <= 1 && ballNum == 0)
            {
              music.clip = m;
              music.Play();

                Destroy(this.gameObject);
                ballNum++;
            }
        }


    }
}
