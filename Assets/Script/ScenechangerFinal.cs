using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenechangerFinal : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject name;
    public void Scene2(string name)
    {
      if (Game5Text_Score.catched==6){
          SceneManager.LoadScene("End");
        }


    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUITED");
    }
}
