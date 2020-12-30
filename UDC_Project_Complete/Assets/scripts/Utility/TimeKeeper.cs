using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeKeeper : MonoBehaviour
{
    float updateTime = 0.0f;
    float jumpTimer = 0.0f;
    static bool isTime3s = false;
    static bool cameraSwap = false;
    static bool shouldRun = false;
    static bool jumpedTimerStarted = false;
    static bool jumpedTimerEnded = true;
    //This Property returns the value of isTime3s private variable
    public static bool IsTime { get{ return isTime3s; } }

    public static bool CameraSwapTime { get { return cameraSwap; } }
    
    public static bool ShouldRun { get { return shouldRun; } }

    public static bool JumpedTimerStarted { get { return jumpedTimerStarted; } set { jumpedTimerStarted = value; } }

    public static bool JumpedTimerEnded { get { return jumpedTimerEnded; } set { jumpedTimerEnded = value; } }


    // FixedUpdate is called once per frame at 60 fps
    void FixedUpdate()
    {
        updateTime += 0.02f;
        if(updateTime >= 2.65f)
        {
            isTime3s = true;
        }
        
        if(updateTime >= 3.65f)
        {
            cameraSwap = true;
        }

        if(updateTime >= 3.5f)
        {
            shouldRun = true;
        }

        if(jumpedTimerStarted && !jumpedTimerEnded)
        {
            if(jumpTimer <= 0.5f)
            {
                jumpTimer += 0.02f;
            }
            else
            {
                jumpedTimerStarted = false;
                jumpedTimerEnded = true;
                jumpTimer = 0.0f;
            }
        }
    }

    public static void PlayerJumped()
    {
        jumpedTimerStarted = true;
        jumpedTimerEnded = false;
    }
}
