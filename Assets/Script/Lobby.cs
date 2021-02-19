using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lobby : MonoBehaviour
{
    public float speed;
    public float distance;

    private Transform target;
    private Transform original;
    private Transform target_player;

    public GameObject punished_Girl;
    public GameObject punished_Boy;

    private GameObject b;

    public Text successText;
    public AudioSource music;
    public AudioClip m;

    public bool check; 

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("LobbyTarget").GetComponent<Transform>();
        original = GameObject.FindGameObjectWithTag("LobbyOriginal").GetComponent<Transform>();
        target_player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        successText.enabled = false;
        check = false;
    }

    private void Awake(){
      music = gameObject.AddComponent<AudioSource>();
      music.playOnAwake = false;
   //m = Resources.Load<AudioClip>("Sound/点击按钮");
     }

    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > distance)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(target.transform.position.x, target.transform.position.y), speed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(original.transform.position.x, original.transform.position.y);
        }

        if (Input.GetKey("space"))
        {
          music.clip = m;
          music.Play();
            if (Vector2.Distance(transform.position, target_player.position) <= 1 )
            {
                Destroy(this.gameObject);
                playermove.numofstudent ++;

                if (this.tag == "girl")
                {
                    b = Instantiate(punished_Girl) as GameObject;
                    b.transform.position = this.transform.position;
                }
                if (this.tag == "boy")
                {
                    b = Instantiate(punished_Boy) as GameObject;
                    b.transform.position = this.transform.position;
                }
            }
        }
        if(playermove.numofstudent >= 2)
        {
            successText.enabled = true;



            successText.text = "Good Job! No Students Running in Lobby Now!";

            Destroy(successText, 5f);
            check = true;
        }

    }

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        Destroy(this.gameObject);

    //        if (this.tag == "girl")
    //        {
    //            b = Instantiate(punished_Girl) as GameObject;
    //            b.transform.position = other.transform.position;
    //        }
    //        if (this.tag == "boy")
    //        {
    //            b = Instantiate(punished_Boy) as GameObject;
    //            b.transform.position = other.transform.position;
    //        }
    //    }


    //}
}
