using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEvent : MonoBehaviour
{
    public static CollisionEvent ThisCollisionEvent;
    public event Action PlayerCollisionEvent;

    // Awake is called before every other method
    void Awake()
    {
        ThisCollisionEvent = this;
    }

    public void PlayerCollisionEventMethod()
    {
        if(PlayerCollisionEvent != null)
        {
            PlayerCollisionEvent();
        }
    }
}
