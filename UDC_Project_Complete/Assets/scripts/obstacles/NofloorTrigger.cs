﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NofloorTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            NoFloorFallingEvent.thisNoFloorFallingEvent.PlayerFallingNoFloor();
        }
    }
}
