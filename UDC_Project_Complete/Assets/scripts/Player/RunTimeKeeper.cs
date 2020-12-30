using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunTimeKeeper : MonoBehaviour
{

    // FixedUpdate is called 50 times per second
    void FixedUpdate()
    {
        if(TimeKeeper.ShouldRun)
        {
            Destroy(gameObject.GetComponent<CharAnimationSync>());
            gameObject.GetComponent<RunNdTurn>().enabled = true;
            Destroy(this);
        }
    }
}
