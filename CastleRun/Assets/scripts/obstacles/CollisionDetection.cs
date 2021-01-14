﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            CollisionEvent.ThisCollisionEvent.PlayerCollisionEventMethod();
        }
    }
}
