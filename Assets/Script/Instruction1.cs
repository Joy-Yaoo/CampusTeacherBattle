using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instruction1 : MonoBehaviour
{
    public Image img_game1;
    public GameObject myButton_game1;

    void Start()
    {
        myButton_game1.SetActive(false);
        img_game1.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        movePoint.playerEneter = true;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            myButton_game1.SetActive(true);
            img_game1.enabled = true;
        }
    }
    public void StartGmage1()
    {
        myButton_game1.SetActive(false);
        img_game1.enabled = false;
		Destroy(myButton_game1);
		Destroy(img_game1);

		movePoint.playerEneter = true;
    }
}
