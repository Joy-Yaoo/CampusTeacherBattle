using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickCheckMask : MonoBehaviour
{



  public static int currentScore;
  public  Text scoreText;
  public  Text resultText;

    public GameObject studentF;
    public GameObject studentM;
    private GameObject a;
    private GameObject b;
    public AudioSource music;
    public AudioClip m;



    void Start()
    {


   }
   private void Awake(){
     music = gameObject.AddComponent<AudioSource>();
     music.playOnAwake = false;
//m = Resources.Load<AudioClip>("Sound/点击按钮");
    }


    void Update(){
          if(Input.GetMouseButtonDown(0))
            {

              Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
              RaycastHit2D rayHit = Physics2D.Raycast(ray, Vector2.zero);
              music.clip = m;
              music.Play();


                if(rayHit){
                  if(rayHit.collider.CompareTag("NoMask")){
                  currentScore += 1;

                  Game1Text_Score.UpdateMessage("Student Without Mask X ", currentScore);
                  Debug.Log(currentScore);
                  a = Instantiate(studentM) as GameObject;
                  a.transform.position = rayHit.transform.position;
                  Destroy(rayHit.collider.gameObject);



                }
                if(rayHit.collider.CompareTag("NOMask2")){
                  currentScore += 1;

                  //scoreText.text= "Catch student X " + currentScore;
                  Game1Text_Score.UpdateMessage("Student Without Mask X ", currentScore);
                  Debug.Log(currentScore);

                  b = Instantiate(studentF) as GameObject;
                  b.transform.position = rayHit.transform.position;
                  Destroy(rayHit.collider.gameObject);

                }
               }

                 // if(currentScore>=4){
                 //   currentScore=4;
                 //
                 // }

              }
}






}
