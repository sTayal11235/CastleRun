using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NoFloorFallingEvent : MonoBehaviour
{
    public static NoFloorFallingEvent thisNoFloorFallingEvent;
    public event Action noPlatformBelow;

    // Start is called before the first frame update
    void Awake()
    {
        thisNoFloorFallingEvent = this;
    }

    public void PlayerFallingNoFloor()
    {
        if(noPlatformBelow != null)
        {
            noPlatformBelow();
        }
    }    
}
