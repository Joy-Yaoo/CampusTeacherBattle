using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playermove : MonoBehaviour
{
	public float movespeed;
	public float movespeedrun;
	public Animator animator;
	public Rigidbody2D rb;
	Vector2 movement;
	Vector2 movement1;


	public AudioSource music;
	public AudioClip m;

    //public Transform sparkle;
    ParticleSystem pa;

	public static int numofstudent = 0;

    void Start()
	{
		//sparkle.GetComponent<ParticleSystem>().enableEmission = false;
        pa = GetComponent<ParticleSystem>();
        pa.Stop();
	}

    // Update is called once per frame
    void Update()
    {
        //awsd
		movement.x = Input.GetAxisRaw("Horizontal");
		movement.y = Input.GetAxisRaw("Vertical");
		animator.SetFloat("Horizontal", movement.x);
		animator.SetFloat("Vertical", movement.y);
		animator.SetFloat("Speed", movement.sqrMagnitude);
		

        //uhjk
		movement1.x = Input.GetAxisRaw("HorizontalK");
		movement1.y = Input.GetAxisRaw("VerticalU");
		animator.SetFloat("HorizontalK", movement1.x);
		animator.SetFloat("VerticalU", movement1.y);
		animator.SetFloat("SpeedS", movement1.sqrMagnitude);}


    void FixedUpdate()
	{
		if (movement.x != 0 || movement.y !=0) { 
		rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);
		}
		else { 
		rb.MovePosition(rb.position + movement1 * movespeedrun * Time.fixedDeltaTime);
		}
	}


	private void Awake()
	{
		music = gameObject.AddComponent<AudioSource>();
		music.playOnAwake = false;

	}

	private void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "ball")
		{
			Debug.Log("ball");
			pa.Play();
			music.clip = m;
			music.Play();
			//SceneManager.LoadScene("DancingLine_fail");

		}
		//sparkle.GetComponent<ParticleSystem>().enableEmission = true;
		//StartCoroutine(stopsparkle()); 
	}

//    IEnumerator stopsparkle()
//	{
 //       yield return new WaitForSeconds(.10f);
//		sparkle.GetComponent<ParticleSystem>().enableEmission = false;
////		Debug.Log("停止系统");
//	}




}
