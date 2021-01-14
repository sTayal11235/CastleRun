using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GateLiftUpEvent : MonoBehaviour
{
    public static GateLiftUpEvent thisGateLiftUpEvent;
    public event Action finishLineCrossed;

    // Awake is called before all other methods
    void Awake()
    {
        thisGateLiftUpEvent = this;
    }

    public void FinishLineCrossed()
    {
        if(finishLineCrossed != null)
        {
            finishLineCrossed();
        }
    }

}
