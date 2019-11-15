﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//additional library we must include to let Unity know
//what Text and other UI script
using UnityEngine.UI;

public class DeltaTimerScript : MonoBehaviour
{
    public Text deltaTimerText; //variable for the Text component from another script
    public float deltaTimer = 36; //the timer starts at 30s

    // Start is called before the first frame update
    void Start()
    {
        print("GAME START"); //print to console
    }

    // Update is called once per frame
    void Update()
    {
        deltaTimer -= Time.deltaTime; //minus the fractions of a second since last frame to deltaTimer
        deltaTimerText.text = "Time: " + deltaTimer; //display the current deltaTimer in deltaTimerText

        //if the deltaTimer is  less than 0
        if(deltaTimer < 0){
            print("GAME OVER"); //print to console
        }

        //print("DeltaTime: " + Time.deltaTime);
    }
}