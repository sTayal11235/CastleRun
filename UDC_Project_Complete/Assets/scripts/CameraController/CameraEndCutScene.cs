using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEndCutScene : MonoBehaviour
{
    [SerializeField] GameObject endCutPos;
    [SerializeField] GameObject Player;
    float camRotTime;
    float smoothIND = 0.125f;

    // Start is called before the first frame update
    void Start()
    {
        camRotTime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = endCutPos.transform.position;
        Quaternion targetRot = endCutPos.transform.rotation;

        if(camRotTime >= 0.5f)
        {
            Vector3 smoothPos = Vector3.Lerp(transform.position, targetPos, smoothIND);
            transform.position = smoothPos;

            transform.LookAt(Player.transform);
        }

        camRotTime += Time.deltaTime;
    }
}
