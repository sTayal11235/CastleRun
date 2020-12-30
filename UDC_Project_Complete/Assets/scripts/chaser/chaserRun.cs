using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaserRun : MonoBehaviour
{
    [SerializeField] float speed = 25.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!TimeKeeper.ShouldRun)
        {
            transform.Translate(0.0f, 0.0f, speed);
        }

        else
        {
            gameObject.GetComponent<chaserPositionLocked>().enabled = true;
        }
    }
}
