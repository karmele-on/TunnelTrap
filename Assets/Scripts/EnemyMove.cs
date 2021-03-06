﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public int enemySpeed;
    public int xMoveDirection;

    void Start()
    {
        
    }

    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(xMoveDirection, 0));
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(xMoveDirection * enemySpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
        if(hit.distance < 1.7)
        {
            Flip();
        }
    }

    void Flip()
    {
        if(xMoveDirection > 0)
        {
            xMoveDirection = -1;
        }
        else
        {
            xMoveDirection = 1;
        }
    }
}
