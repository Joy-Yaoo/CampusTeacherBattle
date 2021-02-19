using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class morningTest : MonoBehaviour
{
   public GameObject studentNormal_CF;
   public GameObject studentNormal_CM;
   public GameObject studentNormal_TF;
   public GameObject studentNormal_TM;
   public GameObject studentNormal_PF;
   public GameObject studentNormal_PM;

   public GameObject studentCopyF;
   public GameObject studentCopyM;
   public GameObject studentTalkF;
   public GameObject studentTalkM;
   public GameObject studentPhoneF;
   public GameObject studentPhoneM;
   //public static bool playerIsEnter;
   public static bool functionHaveCalled=true;



    void Start()
    {

      // Game5Text_Score.playerIsEnter=false;
      studentCopyF.SetActive(false);
      studentCopyM.SetActive(false);
      studentTalkF.SetActive(false);
      studentTalkM.SetActive(false);
      studentPhoneF.SetActive(false);
      studentPhoneM.SetActive(false);






    }


    void Update()
    {
          if(!functionHaveCalled){
           StartCoroutine(copyAppearM());
                functionHaveCalled=true;//make sure method only called once
          }
    }

        //  }




    IEnumerator copyAppearM(){
      //copyAppearF

      yield return new WaitForSeconds(6);
      studentNormal_CF.SetActive(false);
      studentCopyF.SetActive(true);
        Debug.Log("1");
        //copyAppearM;
      yield return new WaitForSeconds(3);
      studentNormal_CM.SetActive(false);
      studentCopyM.SetActive(true);
        Debug.Log("2");
        //TalkAppearF
        yield return new WaitForSeconds(6);
        studentNormal_TF.SetActive(false);
        studentTalkF.SetActive(true);
         Debug.Log("3-1");
         //TalkAppearM
         studentNormal_TM.SetActive(false);
         studentTalkM.SetActive(true);
         Debug.Log("3-2");
        // PhoneAppearF
         yield return new WaitForSeconds(4);
         studentNormal_PF.SetActive(false);
         studentPhoneF.SetActive(true);
         Debug.Log("4");
         //PhoneAppearM
         yield return new WaitForSeconds(2);
            studentNormal_PM.SetActive(false);
            studentPhoneM.SetActive(true);
            Debug.Log("5");


    }

    // public void OnTriggerEnter2D(Collider2D other)
    // {
    //     if(other.tag == "Player")
    //     {
    //         Debug.Log("enter");
    //         playerIsEnter = true;
    //         functionHaveCalled=false;
    //
    //
    //     }
    // }
}
