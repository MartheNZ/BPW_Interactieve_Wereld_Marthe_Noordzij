﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour {

    public bool furnaceIgnite = false;
    public float speedY = 3f;
    public float speedX = 6f;

    private Vector3 start;
    private Vector3 des;
    public Transform des2;
    private float fraction = 0;
    
    public RotorSpin spinning;

	void Start () {
        start = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        des = new Vector3(transform.position.x, 26f, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {

        print("enter");
        if (other.gameObject.name == "FPSController")
        {
            //other.transform.SetParent(transform);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "FPSController")
        { if (fraction < 1)
            {
                //fraction = Mathf.Clamp(fraction + Time.smoothDeltaTime ,0,0.9f);
            }
            print("stay");
            /*if (fraction < 1)
            {
                fraction += Time.deltaTime * speed;
                transform.position = Vector3.Lerp(start, des, fraction);

            }


        if (spinning.spinning == true)
        {

        }*/
            if(fraction < 1)// && fraction >= 0.5f) 
            {
                transform.position = Vector3.MoveTowards(transform.position, des, Time.smoothDeltaTime * speedY);

                if (Vector3.Distance(transform.position, des) <= 0.01f)
                {
                    fraction = 1;
                }

            }
            else
            if (spinning.spinning) //&& fraction >=1)
            {
                transform.position = Vector3.MoveTowards(transform.position, des2.position, Time.smoothDeltaTime * speedX);

                if (Vector3.Distance(transform.position, des2.position) <= 0.01f)
                {
                    fraction = 2;
                }
            }

            /*Vector3 playerPos = other.transform.position;
            playerPos.y = transform.position.y + 1;
            other.transform.position = playerPos;*/

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "FPSController")
        {
            //other.transform.SetParent(null);

            if (fraction < 2 )//&& fraction >= 0.5f)
            {
                transform.position = start;
                fraction = 0;
            }
            

        }
    }

   

    void Update () {
       
	}
}
