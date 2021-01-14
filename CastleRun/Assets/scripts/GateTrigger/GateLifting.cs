using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateLifting : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y <= 0.0f)
        {
            transform.Translate(0.0f, 1.5f * Time.deltaTime, 0.0f);
        }
    }
}
