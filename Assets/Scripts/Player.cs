﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;

    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;

    public int health = 3;
       
    // Update is called once per frame
    private void Update()
    {
        // smoothly transition player between positions      
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        // check if the players y position is less than the max height
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {            
            // move the player up the y axis on up arrow
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);

        // check if the players y position is greater than the min height
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight) {

            // move the player down the y axis on down arrow
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            
        }
    }
    
}
