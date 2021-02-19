using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    public int collectedBall = 0;
    public GameObject textball;
    public GameObject[] array_textball;

    public static bool isTrigger = false;

    public int i = 0;

    public static Text successText;

    private Transform target;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        successText = GameObject.FindGameObjectWithTag("successText").GetComponent<Text>();

        textball.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey("space"))
        {
            if (Vector2.Distance(transform.position, target.position) <= 1 && BallCollect.ballNum == 1)
            {

                array_textball[i].SetActive(true);
                BallCollect.ballNum--;

                Destroy(array_textball[i], 2f);

                i++;
            }
        }
        if(i == 6)
        {
            successText.enabled = true;
            successText.text = "YEAH! You Pick Up All Footballs!";

            Destroy(successText, 10f);
        }
    }

}
