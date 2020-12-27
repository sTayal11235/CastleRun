using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunTimeKeeper : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        if(IdleRunDelay.ShouldRun)
        {
            gameObject.GetComponent<CharAnimationSync>().enabled = false;
            gameObject.GetComponent<RunNdTurn>().enabled = true;
        }
    }
}
