using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public Text WinHint;
    public DeltaTimerScript DeltaTimerScript; // call DeltaTimerScript
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        GameObject otherOjb = other.gameObject;//get the other gameObject

        Rigidbody otherRb = otherOjb.GetComponent<Rigidbody>(); //get it's rigidBody

        otherRb.MovePosition(new Vector3(28, 5, 21));//use MovePosition to move it to the start position

        otherRb.velocity = Vector3.zero;//reset it's velocity to 0,0,0

        WinHint.gameObject.SetActive(true); // activate the winning text

        DeltaTimerScript.ResetTimer(); //Reset the timer to 60s
    }
}
