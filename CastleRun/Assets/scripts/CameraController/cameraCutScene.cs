using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraCutScene : MonoBehaviour
{
    [SerializeField]
    Transform cameraPos;

    float cv = 0.0f;
    float smoothSpeed = 0.05f;
    float smoothAngle = 0.05f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(TimeKeeper.CameraSwapTime)
        {
            float smoothX = Mathf.SmoothDamp(transform.localPosition.x, cameraPos.transform.localPosition.x, ref cv, smoothSpeed);
            float smoothY = Mathf.SmoothDamp(transform.localPosition.y, cameraPos.transform.localPosition.y, ref cv, smoothSpeed);
            float smoothZ = Mathf.SmoothDamp(transform.localPosition.z, cameraPos.transform.localPosition.z, ref cv, smoothSpeed);
            
            transform.position = new Vector3(smoothX, smoothY, smoothZ);

            float smoothAX = Mathf.SmoothDampAngle(transform.localRotation.x, cameraPos.transform.localRotation.x, ref cv, smoothAngle);
            float smoothAY = Mathf.SmoothDampAngle(transform.localRotation.y, cameraPos.transform.localRotation.y, ref cv, smoothAngle);
            float smoothAZ = Mathf.SmoothDampAngle(transform.localRotation.z, cameraPos.transform.localRotation.z, ref cv, smoothAngle);
            
            transform.rotation = Quaternion.Euler(smoothAX, smoothAY, smoothAZ);
            
        }
    }
}
