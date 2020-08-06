using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;



public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float Dforce = 50;
    public float Sforce = 50;
    float time = 3.0f;

    public GameObject intro;


    void Start()
    {
        intro.SetActive(true);
        
    }


   void FixedUpdate()
   {
        rb.useGravity = true;
        if (time >= 0)
        {
            time -= Time.deltaTime;
            return;
        }
        else
        {
            //driving force of the ball
            rb.AddForce(-Dforce * Time.deltaTime, 0, 0);


            //direction controls
            if (Input.GetKey("d") || Input.GetKey("right"))
            {
                rb.AddForce(0, 0, Sforce * Time.deltaTime);
            }

            if (Input.GetKey("a") || Input.GetKey("left"))
            {
                rb.AddForce(0, 0, -Sforce * Time.deltaTime);
            }
        }
    }
}
