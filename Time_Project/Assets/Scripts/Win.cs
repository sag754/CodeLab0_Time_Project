using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public Text WinHint;
    public AudioSource audioClip;
    public DeltaTimerScript DeltaTimerScript; // call DeltaTimerScript
    // Start is called before the first frame update
    void Start()
    {
        audioClip = GetComponent<AudioSource>(); //get audiosource component to enable sound to be played
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DisableText()
    {
        WinHint.gameObject.SetActive(false);//deactivate the winning text
    }

    public void OnTriggerEnter(Collider other)  // if the player collides with this trigger box, do this
    {
        GameObject otherOjb = other.gameObject;//get the other gameObject

        Rigidbody otherRb = otherOjb.GetComponent<Rigidbody>(); //get it's rigidBody

        otherRb.MovePosition(new Vector3(28, 5, 21));//use MovePosition to move it to the start position

        otherRb.velocity = Vector3.zero;//reset it's velocity to 0,0,0

        WinHint.gameObject.SetActive(true);//activate the winning text

        if (gameObject.active = true)//checks if the game object has been set to active
        {
            Invoke("DisableText", 3);//if game object is active, call disabletext after 3 seconds
        }

        DeltaTimerScript.ResetTimer(); //Reset the timer to 60s

        audioClip.Play(); //play sound effect on collide
    }
}
