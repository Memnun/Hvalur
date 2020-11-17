using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipsteer : MonoBehaviour
{

    public Vector3 windvel;
    public Vector3 currvel;

    public Vector3 sailangle;
    public float sailarea;
    public float rudderAngle;

    private Rigidbody body;
    
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 force = new Vector3(0,0,0);

        if (Vector3.Angle(windvel, body.transform.forward) >= 90)
        {
            force = Vector3.Project((body.velocity-Vector3.Project(windvel,sailangle.normalized)),body.transform.forward) * sailarea;
        }
        else
        {
            force = Vector3.Project((Vector3.Project(windvel,Vector3.Cross(sailangle,body.transform.up).normalized) - body.velocity ), body.transform.forward) * sailarea;
        }
        
        
        body.AddForce(currvel);
        body.AddForce(force);
        body.AddTorque(force.magnitude * body.transform.up * rudderAngle);
    }
}
