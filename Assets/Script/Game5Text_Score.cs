using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Game5Text_Score : MonoBehaviour
{


  public GameObject studentSF; //standfemale
  public GameObject studentSM;
  public Text catchText;
  public Text winText;

  public static int catched;
  private GameObject a2;
  private GameObject b2;
  public static bool playerIsEnter;
  public AudioSource music;
  public AudioClip m;


    void Start()
    {
      playerIsEnter=false;
      catchText = GameObject.Find("catchText").GetComponent<Text>();
      winText = GameObject.Find("winText").GetComponent<Text>();

      catched = 0;
    }

    private void Awake()
    {
      music = gameObject.AddComponent<AudioSource>();
      music.playOnAwake = false;

    }
    void Update()
    {

      if(Input.GetMouseButtonDown(0))
        {
          Vector2 ray2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
          RaycastHit2D rayHit2 = Physics2D.Raycast(ray2, Vector2.zero);
          music.clip = m;
          music.Play();

            if(rayHit2){
              if(rayHit2.collider.CompareTag("badStudentF")){
              catched += 1;

              catchText.text= "Catch student X " + catched;

              a2 = Instantiate(studentSF) as GameObject;
              a2.transform.position = new Vector2(rayHit2.transform.position.x, rayHit2.transform.position.y - 0.1f);
              Destroy(rayHit2.collider.gameObject);
            }
            if(rayHit2.collider.CompareTag("badStudentM")){
              catched += 1;

             catchText.text= "Catch student X " + catched;

              b2 = Instantiate(studentSM) as GameObject;
              b2.transform.position = new Vector2(rayHit2.transform.position.x, rayHit2.transform.position.y - 0.1f);
              Destroy(rayHit2.collider.gameObject);

              }

              if(catched==6){
                  winText.text= "Success! You Catch all the students";
                  Destroy(winText.gameObject, 2f);
                  Destroy(catchText.gameObject, 3f);
                  StartCoroutine(checkResult());
                //  SceneManager.LoadScene("End");

              }

            }
          }
      }

      IEnumerator checkResult(){
        if(catched==6){
           yield return new WaitForSeconds(2);
           SceneManager.LoadScene("End");
        }
      }

          public void OnTriggerEnter2D(Collider2D other)
          {
              if(other.tag == "Player")
              {
                //  catchText.text="catch student who cheat on Test";
                  Debug.Log("enter");
                  playerIsEnter = true;
                  morningTest.functionHaveCalled=false;



              }
          }



  }
