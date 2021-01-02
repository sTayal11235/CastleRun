using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<CameraEndCutScene>().enabled = false;
        GateLiftUpEvent.thisGateLiftUpEvent.finishLineCrossed += CamRotScript;
    }

    void CamRotScript()
    {
        gameObject.GetComponent<CameraFollower>().enabled = false;
        gameObject.GetComponent<CameraEndCutScene>().enabled = true;
    }

}
