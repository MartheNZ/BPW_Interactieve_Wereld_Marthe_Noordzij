using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceMelt : MonoBehaviour
{
    public AudioClip SoundToPlay;
    public float Volume;
    new AudioSource audio;

    //public ParticleSystem steam;
    
    void Start()
    {
        audio = GetComponent<AudioSource>();
        //steam = GetComponent<ParticleSystem>();
    }

    void Update()
    { }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "FPSController")
        {
            audio.PlayOneShot(SoundToPlay, Volume);
            //steam.Play();
        }
    }

    void OnTriggerStay(Collider other)
        {
        if (other.gameObject.name == "FPSController")
        {
            transform.localScale += new Vector3(-0.2F, -0.4F, -0.2F);
        }
        }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "FPSController")
        {
            audio.Stop();
            //steam.Stop();
        }
    }


}
