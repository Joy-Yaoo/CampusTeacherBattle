using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Howtoplay : MonoBehaviour
{

    public Image img_howtoplay;

    public GameObject myButton_howtoplay;

    public GameObject button_close;


    // Start is called before the first frame update
    void Start()
    {
        myButton_howtoplay.SetActive(true);
        button_close.SetActive(false);

        img_howtoplay.enabled = false;
    }

   

    public void howtoplay()
    {
        myButton_howtoplay.SetActive(false);

        button_close.SetActive(true);

        img_howtoplay.enabled = true;
    }

    public void Close()
    {
        myButton_howtoplay.SetActive(true);

        button_close.SetActive(false);

        img_howtoplay.enabled = false;
    }
}
