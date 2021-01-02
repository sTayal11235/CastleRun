using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStationaryLookAt : MonoBehaviour
{
    [SerializeField] GameObject target;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform);
    }
}
