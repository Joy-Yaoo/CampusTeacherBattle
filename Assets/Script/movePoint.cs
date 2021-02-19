using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePoint : MonoBehaviour
{
    public float speed;

    public GameObject[] moveSpots;

    private int i = 0;
    float currentSpot;
    public GameObject  objectToDisappear;

    public bool down = true;

    public static bool playerEneter;

    void Start()
    {

        speed = Random.Range(1, 2);
        playerEneter = false;
    }

    void Update()
    {
        if(playerEneter == true)
        {
            if (i == 0)
            {
                down = true;

            }

            if (down == true)
            {
                currentSpot = Vector3.Distance(this.transform.position, moveSpots[i].transform.position);

                transform.position = Vector3.MoveTowards(this.transform.position, moveSpots[i].transform.position, Time.deltaTime * speed);

                if (currentSpot < 0.1f && i < moveSpots.Length - 1)
                {
                    i++;
                }
            }
        }
        


    //  if(i == moveSpots.Length )
      if(Vector3.Distance(this.transform.position, moveSpots[moveSpots.Length-1].transform.position) < 0.02f)
      {

          down = false;

      }
      if(down == false)
      {
       Destroy(objectToDisappear,1f);

      }



    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
           
        }
    }
}
