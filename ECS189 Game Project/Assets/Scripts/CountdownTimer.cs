﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    //[SerializeField] private 
    private float timeLeft = 0f;
    private readonly float startingTime = 90f;

    // Start is called before the first frame update
    void Start()
    {
        // Game starts with 90 seconds.
        timeLeft = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= 1 * Time.deltaTime;
        if (timeLeft < 0)
        {
            //GameOver(); // Need to make a GameOver() function
        }
    }
}