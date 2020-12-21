using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSteer : MonoBehaviour
{

    public Vector3 WindVelocity;
    public Vector3 CurrentVelocity;

    public Vector3 SailAngle;
    public float SailArea;
    public float RudderAngle;

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

        if (Vector3.Angle(WindVelocity, body.transform.forward) >= 90)
        {
            force = Vector3.Project((body.velocity-Vector3.Project(WindVelocity,SailAngle.normalized)),body.transform.forward) * SailArea;
        }
        else
        {
            force = Vector3.Project((Vector3.Project(WindVelocity,Vector3.Cross(SailAngle,body.transform.up).normalized) - body.velocity ), body.transform.forward) * SailArea;
        }
        
        
        body.AddForce(CurrentVelocity);
        body.AddForce(force);
        body.AddTorque(force.magnitude * body.transform.up * RudderAngle);
    }
}
