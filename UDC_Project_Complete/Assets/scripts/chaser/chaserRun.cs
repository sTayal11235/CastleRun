using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaserRun : MonoBehaviour
{
    [SerializeField] float speed;

    // Update is called once per frame
    void Update()
    {
        if(!TimeKeeper.ShouldRun)
        {
            transform.Translate(0.0f, 0.0f, speed * Time.deltaTime);
        }

        else
        {
            gameObject.GetComponent<chaserPositionLocked>().enabled = true;
        }
    }
}
