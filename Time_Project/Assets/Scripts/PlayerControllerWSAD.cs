using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerWSAD : MonoBehaviour
{
    Rigidbody rb; //declare a reference for the rigidbody

    public GameObject camera;
    public float force = 100.0f; //create a force to push the playerObject
    bool isSmall = false;
    public bool gameOver = false; //create the bool


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //get the rigidbody from this playerObject
    }

    // Update is called once per frame
    void Update()
    {
        bool hasInput = false; //create a local variable to track whether the user has inputed something
      

        if (Input.GetKey(KeyCode.W) && !gameOver)             //allows input from the player for the W key
        { //if the W is pressed
            Vector3 cameraforward = camera.transform.forward; //gets the camera forward position
            cameraforward.y = 0;                              //locks the camera's Y-axis to 0 so it doesn't elevate when moving the camera
            cameraforward = Vector3.Normalize(cameraforward); //forces the camera's forward position to stay flat to avoid flying or sinking
            rb.AddForce(cameraforward * force);               //add force to the camera's forward position to move FORWARD
            hasInput = true; //the user has pressed a key
        }

        if (Input.GetKey(KeyCode.S) && !gameOver)             //allows input from the player for the S key
        { //if the S is pressed
            Vector3 cameraforward = camera.transform.forward; //gets the camera forward position
            cameraforward.y = 0;                              //locks the camera's Y-axis to 0 so it doesn't elevate when moving the camera
            cameraforward = Vector3.Normalize(cameraforward); //forces the camera's forward position to stay flat to avoid flying or sinking
            rb.AddForce(cameraforward * -force);              //add -force to the camera's forward position to move BACKWARDS
            hasInput = true; //the user has pressed a key
        }

        if (Input.GetKey(KeyCode.A) && !gameOver)            //allows input from the player for the A key
        { //if the A is pressed
            Vector3 cameraright = camera.transform.right;    //gets the camera's right position
            cameraright.y = 0;                               //locks the camera's Y-axis to 0 so it doesn't elevate when moving the camera
            cameraright = Vector3.Normalize(cameraright);    //forces the camera's right position to stay flat to avoid flying or sinking
            rb.AddForce(cameraright * -force);               //add -force to the camera's right position to move LEFT
            hasInput = true; //the user has pressed a key
        }

        if (Input.GetKey(KeyCode.D) && !gameOver)           //allows input from the player for the D key
        {//if the D is pressed
            Vector3 cameraright = camera.transform.right;   //gets the camera's right position
            cameraright.y = 0;                              //locks the camera's Y-axis to 0 so it doesn't elevate when moving the camera
            cameraright = Vector3.Normalize(cameraright);   //forces the camera's right position to stay flat to avoid flying or sinking
            rb.AddForce(cameraright * force);               //add force to the camera's right position to move RIGHT
            hasInput = true; //the user has pressed a key
        }

        if (!Input.anyKey)
        { //if the user hasn't pressed a key
            rb.velocity = rb.velocity * 1.0f; //decrease velocity
        }

    }
}