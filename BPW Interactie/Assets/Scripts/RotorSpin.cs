﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotorSpin : MonoBehaviour {
    public bool spinning = false;
        
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (spinning == true)
        {
            transform.Rotate(Vector3.up, 450 * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FPSController")
        {
            spinning = true;
        }
    }
}
