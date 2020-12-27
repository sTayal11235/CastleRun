using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAnimationSync : MonoBehaviour
{
    float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<IdleRunDelay>();
        transform.localRotation = Quaternion.identity;
        transform.localRotation = Quaternion.Euler(0, 180, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (IdleRunDelay.IsTime && gameObject.transform.localRotation.y > 0)
        {
            transform.Rotate(0, -10, 0);
        }
    }
}

//