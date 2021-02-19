using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public AudioSource music;
	public AudioClip m;

	public float speed;
	private Rigidbody2D rb;
	//music.clip = m;
	//		music.Play();

    public static bool isTrigger = false;

    private Transform target;

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
    
       
       

    }
	
}
