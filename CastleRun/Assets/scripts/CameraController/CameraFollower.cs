using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField]
    Transform player;

    float lag = 0.125f;

    void FixedUpdate()
    {
        Vector3 desirePos = player.position;
        Vector3 smoothPos = Vector3.Lerp(transform.position, desirePos, lag);
        transform.position = smoothPos;

        Quaternion desiredRotation = player.rotation;
        Quaternion smoothRot = Quaternion.Lerp(transform.rotation, desiredRotation, lag);
        transform.rotation = smoothRot;

    }
}
