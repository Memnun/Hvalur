using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buoyancy : MonoBehaviour
{

    private Vector3 M0;

    private Vector3 M1;
    private Vector3 M2;
    private Vector3 M3;
    private Vector3 M4;

    private float d1;
    private float d2;
    private float d3;
    private float d4;
    
    private float mass;

    public Rigidbody body;
    public float drag;
    
    // Start is called before the first frame update
    void Start()
    {
        mass = body.mass;
        
        M0 = body.centerOfMass;
        Bounds b = GetComponent<MeshFilter>().mesh.bounds;
        
        M1 = new Vector3(b.min.x, M0.y, M0.z);
        M2 = new Vector3(b.max.x, M0.y, M0.z);
        M3 = new Vector3(M0.x, M0.y, b.min.z);
        M4 = new Vector3(M0.x, M0.y, b.max.z);

        d1 = Vector3.Distance(M0, M1);
        d2 = Vector3.Distance(M0, M2);
        d3 = Vector3.Distance(M0, M3);
        d4 = Vector3.Distance(M0, M4);
    }

    // Update is called once per frame
    void Update()
    {
        //simple buoyancy
        if (transform.position.y < 0)
        {
            body.AddForce(new Vector3(0,transform.position.y*transform.position.y*mass*drag,0));
        }
        //righting buoyancy
        /*if (transform.TransformPoint(M1).y < 0)
        {
            body.AddForceAtPosition(new Vector3(0,(d1*d1*(d3+d4)*mass),0), transform.TransformPoint(M1));
        }
        if (transform.TransformPoint(M2).y < 0)
        {
            body.AddForceAtPosition(new Vector3(0,(d2*d2*(d3+d4)*mass),0), transform.TransformPoint(M2));
        }
        if (transform.TransformPoint(M3).y < 0)
        {
            body.AddForceAtPosition(new Vector3(0,(d3*d3*(d1+d2)*mass),0), transform.TransformPoint(M3));
        }
        if (transform.TransformPoint(M4).y < 0)
        {
            body.AddForceAtPosition(new Vector3(0,(d4*d4*(d1+d2)*mass),0), transform.TransformPoint(M4));
        }*/
        
        if (transform.TransformPoint(M1).y < 0)
        {
            body.AddForceAtPosition(new Vector3(0,Math.Abs(transform.TransformPoint(M1).y*mass*drag),0), transform.TransformPoint(M1));
        }
        if (transform.TransformPoint(M2).y < 0)
        {
            body.AddForceAtPosition(new Vector3(0,Math.Abs(transform.TransformPoint(M2).y*mass*drag),0), transform.TransformPoint(M2));
        }
        if (transform.TransformPoint(M3).y < 0)
        {
            body.AddForceAtPosition(new Vector3(0,Math.Abs(transform.TransformPoint(M3).y*mass*drag),0), transform.TransformPoint(M3));
        }
        if (transform.TransformPoint(M4).y < 0)
        {
            body.AddForceAtPosition(new Vector3(0,Math.Abs(transform.TransformPoint(M4).y*mass*drag),0), transform.TransformPoint(M4));
        }
    }

}
