using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowDisable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<CameraStationaryLookAt>().enabled = false;

        CollisionEvent.ThisCollisionEvent.PlayerCollisionEvent += DisableCameraFollow;
        CollisionEvent.ThisCollisionEvent.PlayerCollisionEvent += EnableCameraLookAt;

        NoFloorFallingEvent.thisNoFloorFallingEvent.noPlatformBelow += DisableCameraFollow;
        NoFloorFallingEvent.thisNoFloorFallingEvent.noPlatformBelow += EnableCameraLookAt;
    }

    void DisableCameraFollow()
    {
        gameObject.GetComponent<CameraFollower>().enabled = false;
    }

    void EnableCameraLookAt()
    {
        gameObject.GetComponent<CameraStationaryLookAt>().enabled = true;
    }
}
