using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAnimationSync : MonoBehaviour
{
    int count = 18;

    // Start is called before the first frame update
    void Start()
    {
        transform.localRotation = Quaternion.identity;
        transform.localRotation = Quaternion.Euler(0, 180, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (TimeKeeper.IsTime && count != 0)
        {
            transform.Rotate(0, -10, 0);
            count -= 1;
        }

        else if(gameObject.transform.localRotation.y < 0)
        {
            gameObject.transform.rotation = Quaternion.identity;
        }
    }
}

//