using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playground : MonoBehaviour
{
    public Image img;
    public GameObject myButton; 

    public static bool playerEnter = false;

    void Start()
    {
        myButton.SetActive(false);
        img.enabled = false;
    }

    void Update()
    {
        if(playerEnter == true)
        {
            img.enabled = false;
            myButton.SetActive(false);
        }
    }
   

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            img.enabled = true;
            myButton.SetActive(true);

        }
    }

}
