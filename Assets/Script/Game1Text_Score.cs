using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game1Text_Score : MonoBehaviour
{

  //  public  int currentScore;
    public static Text scoreText;
    public static Text resultText;
    private bool onlyrunOnce=false;


    void Start()
    {
      scoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<Text>();
      resultText = GameObject.FindGameObjectWithTag("resultText").GetComponent<Text>();
      //scoreText.text="Catch student without mask";
      //UpdateMessage(scoreText.text,clickCheckMask.currentScore);

    }


    void Update()
    {
      if(!onlyrunOnce){
      if(clickCheckMask.currentScore==4){
         resultText.text= "Success! You Find Out All Students Without Mask";
         // Destroy(resultText.gameObject, 2f);
         // Destroy(scoreText.gameObject, 3f);
          onlyrunOnce=true;
      }
    }

    }

    public static void UpdateMessage(string message,int value){
       scoreText.text = message+value;


    }

    public void OnTriggerEnter2D(Collider2D other)
          {
              if(other.tag == "Player")
              {
                if(clickCheckMask.currentScore<4){
              //  resultText.text= "You Need to Catch at least 4 students";
               }
                if(clickCheckMask.currentScore>=4){
                Destroy(scoreText.gameObject);
                Destroy(resultText.gameObject);

               }
              }
          }


}
