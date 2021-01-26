using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buoyancy : MonoBehaviour
{

    public float mass;

    public Rigidbody body;
    public float drag;
    
    // Start is called before the first frame update
    void Start()
    {
        mass = 100;
        drag = 0.8F;
    }
 
    // FixedUpdate is called at fixed time intervals
    void FixedUpdate()
    {
        //simple buoyancy
        if (transform.position.y < 0)
        {
            body.AddForceAtPosition(new Vector3(0, transform.position.y * transform.position.y * mass * drag, 0), transform.position);
        }
    }

}
