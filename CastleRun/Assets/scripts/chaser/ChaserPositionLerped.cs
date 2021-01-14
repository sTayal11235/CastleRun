using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaserPositionLerped : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] Vector3 offset;
    float smoothIndex;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        smoothIndex = 0.125f;
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = target.transform.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, targetPos, smoothIndex);
        transform.position = smoothPos;

        if (transform.position == smoothPos)
        {
            gameObject.transform.LookAt(target.transform);
            anim.SetTrigger("chaserIdle");
        }
    }
}
