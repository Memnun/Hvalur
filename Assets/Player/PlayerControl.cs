using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float moveSpeed;
    public float mouseSensitivity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate(moveSpeed * Input.GetAxis("Horizontal"), 0, 0);
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(0, 0, moveSpeed * Input.GetAxis("Vertical"));
        }

        if (Input.GetAxis("Mouse X") != 0)
        {
            transform.Rotate(0, mouseSensitivity * Input.GetAxis("Mouse X"), 0);
        }

        if (Input.GetAxis("Mouse Y") != 0)
        {
            transform.GetComponentInChildren<Camera>().transform.Rotate(mouseSensitivity * Input.GetAxis("Mouse Y") * -1, 0, 0);
        }
        
        
    }
}
