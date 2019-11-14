using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerWSAD : MonoBehaviour
{
    Rigidbody rb; //declare a reference for the rigidbody

    public GameObject camera;
    public float force = 100.0f; //create a force to push the playerObject
    bool isSmall = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //get the rigidbody from this playerObject
    }

    // Update is called once per frame
    void Update()
    {
        bool hasInput = false; //create a local variable to track whether the user has inputed something

        if (Input.GetKey(KeyCode.W))
        { //if the W is pressed
            Vector3 cameraforward = camera.transform.forward;
            cameraforward.y = 0;
            cameraforward = Vector3.Normalize(cameraforward);
            rb.AddForce(cameraforward * force);
            hasInput = true; //the user has pressed a key
        }

        if (Input.GetKey(KeyCode.S))
        { //if the S is pressed
            Vector3 cameraforward = camera.transform.forward;
            cameraforward.y = 0;
            cameraforward = Vector3.Normalize(cameraforward);
            rb.AddForce(cameraforward * -force);
            hasInput = true; //the user has pressed a key
        }

        if (Input.GetKey(KeyCode.A))
        { //if the A is pressed
            Vector3 cameraright = camera.transform.right;
            cameraright.y = 0;
            cameraright = Vector3.Normalize(cameraright);
            rb.AddForce(cameraright * -force);
            hasInput = true; //the user has pressed a key
        }

        if (Input.GetKey(KeyCode.D))
        {//if the D is pressed
            Vector3 cameraright = camera.transform.right;
            cameraright.y = 0;
            cameraright = Vector3.Normalize(cameraright);
            rb.AddForce(cameraright * force);
            hasInput = true; //the user has pressed a key
        }

        if (!Input.anyKey)
        { //if the user hasn't pressed a key
            rb.velocity = rb.velocity * 1.0f; //decrease velocity
        }

    }
}