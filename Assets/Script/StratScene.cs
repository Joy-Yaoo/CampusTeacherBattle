using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StratScene : MonoBehaviour
{
    public GameObject myButton_start;

    public Image img_intro;
    public GameObject myButton_intro;


    void Start()
    {
        myButton_intro.SetActive(false);
        img_intro.enabled = false;
        myButton_start.SetActive(true);
    }

    public void Introduction()
    {
        myButton_intro.SetActive(true);
        img_intro.enabled = true;
        myButton_start.SetActive(false);
    }
  

    public void StartGmage()
    {
        SceneManager.LoadScene("Main");
    }
}
