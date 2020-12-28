using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraComponentManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(IdleRunDelay.ShouldRun)
        {
            Destroy(gameObject.GetComponent<cameraCutScene>());
            gameObject.GetComponent<CameraFollower>().enabled = true;
            Destroy(this);
        }
    }
}
