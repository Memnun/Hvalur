using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buoyancy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //base buoyant force
        if (transform.position.y < 0)
        {
            transform.GetComponent<Rigidbody>().AddForce(0, 10*transform.position.y*transform.position.y, 0);
        }
    }
}
