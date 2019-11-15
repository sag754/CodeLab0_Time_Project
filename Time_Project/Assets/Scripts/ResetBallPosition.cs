using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBallPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //if something hits this trigger
    private void OnTriggerEnter(Collider other)
    {
        GameObject otherOjb = other.gameObject;//get the other gameObject

        Rigidbody otherRb = otherOjb.GetComponent<Rigidbody>(); //get it's rigidBody

        otherRb.MovePosition(new Vector3(28, 5, 21));//use MovePosition to move it to the start position

        otherRb.velocity = Vector3.zero;//reset it's velocity to 0,0,0

        deltaTimer =
    }
    
}
