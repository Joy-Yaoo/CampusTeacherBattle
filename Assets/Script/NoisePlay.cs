using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoisePlay : MonoBehaviour
{
    public AudioSource audioSource;
    public Transform target;
    public Transform target2;
    public Transform player;
    public static float curVol = 0f;

    public static bool isTrigger = false;
    public static bool talking1 = true;
    public static bool talking2 = true;

    public float distance;
    public float distance2;

    public Text successText;

    public int numofstudent = 0;

    public bool check;

    void Start()
    {
        audioSource.Play();
        audioSource.volume = curVol;
        successText.enabled = false;

        check = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(talking1 == false && talking2 == false)
        {
            

            successText.enabled = true;
            successText.text = "Excellent! Class Is Quiet Now! ";

            Destroy(successText, 5f);
            check = true;
        }

        if(isTrigger == true)
        {
            if(talking1 == true)
            {
                distance = Vector2.Distance(player.position, target.position);
                if (Vector2.Distance(player.position, target.position) >= 1)
                {
                    curVol = 0.1f;
                    audioSource.volume = curVol;
                    distance = Vector2.Distance(player.position, target.position);
                }
                if (Vector2.Distance(player.position, target.position) < 1 && Vector2.Distance(player.position, target.position) >= 0.8)
                {
                    curVol = 0.4f;
                    audioSource.volume = curVol;
                    distance = Vector2.Distance(player.position, target.position);
                }
                if (Vector2.Distance(player.position, target.position) < 0.8 && Vector2.Distance(player.position, target.position) >= 0.7)
                {
                    curVol = 0.5f;
                    audioSource.volume = curVol;
                    distance = Vector2.Distance(player.position, target.position);
                }
                if (Vector2.Distance(player.position, target.position) < 0.7 && Vector2.Distance(player.position, target.position) >= 0.6)
                {
                    curVol = 0.6f;
                    audioSource.volume = curVol;
                    distance = Vector2.Distance(player.position, target.position);
                }
                if (Vector2.Distance(player.position, target.position) < 0.6 && Vector2.Distance(player.position, target.position) >= 0.55)
                {
                    curVol = 0.7f;
                    audioSource.volume = curVol;
                }
                if (Vector2.Distance(player.position, target.position) < 0.55 && Vector2.Distance(player.position, target.position) >= 0.5)
                {
                    curVol = 0.8f;
                    audioSource.volume = curVol;
                    distance = Vector2.Distance(player.position, target.position);
                }
                if (Vector2.Distance(player.position, target.position) < 0.5 && Vector2.Distance(player.position, target.position) >= 0.4)
                {
                    curVol = 0.9f;
                    audioSource.volume = curVol;
                }
                if (Vector2.Distance(player.position, target.position) < 0.4 && Vector2.Distance(player.position, target.position) >= 0)
                {
                    curVol = 0.9f;
                    audioSource.volume = curVol;
                    distance = Vector2.Distance(player.position, target.position);
                }
             
                
            }
            if (talking1 == false)
            {
                curVol = 0f;
       


            }
            audioSource.volume = curVol;

            if (talking2 == true)
            {
                distance2 = Vector2.Distance(player.position, target2.position);
                if (Vector2.Distance(player.position, target2.position) >= 1)
                {
                    curVol = 0.3f;
                    audioSource.volume = curVol;
                    distance = Vector2.Distance(player.position, target2.position);
                }
                if (Vector2.Distance(player.position, target2.position) < 1 && Vector2.Distance(player.position, target2.position) >= 0.8)
                {
                    curVol = 0.4f;
                    audioSource.volume = curVol;
                    distance = Vector2.Distance(player.position, target2.position);
                }
                if (Vector2.Distance(player.position, target2.position) < 0.8 && Vector2.Distance(player.position, target2.position) >= 0.7)
                {
                    curVol = 0.5f;
                    audioSource.volume = curVol;
                    distance = Vector2.Distance(player.position, target2.position);
                }
                if (Vector2.Distance(player.position, target2.position) < 0.7 && Vector2.Distance(player.position, target2.position) >= 0.6)
                {
                    curVol = 0.6f;
                    audioSource.volume = curVol;
                    distance = Vector2.Distance(player.position, target2.position);
                }
                if (Vector2.Distance(player.position, target2.position) < 0.6 && Vector2.Distance(player.position, target2.position) >= 0.55)
                {
                    curVol = 0.7f;
                    audioSource.volume = curVol;
                }
                if (Vector2.Distance(player.position, target2.position) < 0.55 && Vector2.Distance(player.position, target2.position) >= 0.5)
                {
                    curVol = 0.8f;
                    audioSource.volume = curVol;
                    distance = Vector2.Distance(player.position, target2.position);
                }
                if (Vector2.Distance(player.position, target2.position) < 0.5 && Vector2.Distance(player.position, target2.position) >= 0.4)
                {
                    curVol = 0.9f;
                    audioSource.volume = curVol;
                }
                if (Vector2.Distance(player.position, target2.position) < 0.4 && Vector2.Distance(player.position, target2.position) >= 0)
                {
                    curVol = 0.9f;
                    audioSource.volume = curVol;
                    distance = Vector2.Distance(player.position, target2.position);
                }

            }
            if (talking2 == false)
            {
                curVol = 0f;
                numofstudent++;
            }



        }


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" )
        {
         
            audioSource.volume = curVol;
            isTrigger = true;
        }
    }
}
