using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaserRunActivator : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<ChaserPositionLerped>().enabled = false;
        CollisionEvent.ThisCollisionEvent.PlayerCollisionEvent += AutoRunActivator;
    }

    void AutoRunActivator()
    {
        gameObject.GetComponent<chaserPositionLocked>().enabled = false;
        gameObject.GetComponent<ChaserPositionLerped>().enabled = true;
    }
}
