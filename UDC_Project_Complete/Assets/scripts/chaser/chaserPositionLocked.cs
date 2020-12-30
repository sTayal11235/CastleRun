using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaserPositionLocked : MonoBehaviour
{
    [SerializeField]
    Transform chaserBait;

    float lag = 0.125f;

    private void Start()
    {
        gameObject.GetComponent<chaserRun>().enabled = false;
    }

    void FixedUpdate()
    {
        Vector3 desirePos = chaserBait.position;
        Vector3 smoothPos = Vector3.Lerp(transform.position, desirePos, lag);
        transform.position = smoothPos;

        Quaternion desiredRotation = chaserBait.rotation;
        Quaternion smoothRot = Quaternion.Lerp(transform.rotation, desiredRotation, lag);
        transform.rotation = smoothRot;

    }
}
