﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject gameOver;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Game");                                   
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene("Start");
        }
    }
}
