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
        if(IdleRunDelay.CameraSwapTime)
        {
            float smoothX = Mathf.SmoothDamp(transform.position.x, cameraPos.transform.position.x, ref cv, smoothSpeed);
            float smoothY = Mathf.SmoothDamp(transform.position.y, cameraPos.transform.position.y, ref cv, smoothSpeed);
            float smoothZ = Mathf.SmoothDamp(transform.position.z, cameraPos.transform.position.z, ref cv, smoothSpeed);
            
            transform.position = new Vector3(smoothX, smoothY, smoothZ);

            float smoothAX = Mathf.SmoothDampAngle(transform.eulerAngles.x, cameraPos.transform.eulerAngles.x, ref cv, smoothAngle);
            float smoothAY = Mathf.SmoothDampAngle(transform.eulerAngles.y, cameraPos.transform.eulerAngles.y, ref cv, smoothAngle);
            float smoothAZ = Mathf.SmoothDampAngle(transform.eulerAngles.z, cameraPos.transform.eulerAngles.z, ref cv, smoothAngle);
            
            transform.rotation = Quaternion.Euler(smoothAX, smoothAY, smoothAZ);
            
        }
    }
}
