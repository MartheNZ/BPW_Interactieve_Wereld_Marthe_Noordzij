﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MeltNoise : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerStay(Collider other)
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();

    }

    // Update is called once per frame
    void Update () {
		
	}
}
