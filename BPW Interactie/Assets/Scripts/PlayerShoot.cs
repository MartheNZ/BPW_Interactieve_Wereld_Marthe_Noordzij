using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public delegate void shootcallback(Collider collider);
    private new Collider collider = null;

    public event shootcallback shoot = null;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (shoot != null)
            {
                shoot(collider);

            }
        }
    }

    public void alert(Collider collider)
    {
        this.collider = collider;
    }

        
 
        
       
 }
