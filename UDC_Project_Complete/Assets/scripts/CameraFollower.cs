using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField]
    Transform player;


    [SerializeField]
    Vector3 offsetPosition;

    float lag = 0.125f;

    // LateUpdate is called once per frame after all the other methods have been execute
    void FixedUpdate()
    {
        Vector3 desirePos = player.position + offsetPosition;
        Vector3 smoothPos = Vector3.Lerp(transform.position, desirePos, lag);
        transform.position = smoothPos;

    }
}
