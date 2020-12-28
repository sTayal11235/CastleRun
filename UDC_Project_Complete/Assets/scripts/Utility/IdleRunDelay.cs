using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleRunDelay : MonoBehaviour
{
    float updateTime = 0.0f;
    static bool isTime3s = false;
    static bool cameraSwap = false;
    static bool shouldRun = false;

    //This Property returns the value of isTime3s private variable
    public static bool IsTime { get{ return isTime3s; } }

    public static bool CameraSwapTime { get { return cameraSwap; } }
    
    public static bool ShouldRun { get { return shouldRun; } }
    
    // FixedUpdate is called once per frame at 60 fps
    void FixedUpdate()
    {
        updateTime += 0.02f;
        if(updateTime >= 2.65f)
        {
            isTime3s = true;
        }

        if(updateTime >= 2.8f)
        {
            cameraSwap = true;
        }

        if(updateTime >= 4.0f)
        {
            shouldRun = true;
        }
    }
}
