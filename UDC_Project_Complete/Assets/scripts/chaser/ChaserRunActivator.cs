using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaserRunActivator : MonoBehaviour
{
    Animator anim;
    [SerializeField] GameObject target;
    [SerializeField] Vector3 offset;
    [SerializeField] Vector3 ROffset;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        CollisionEvent.ThisCollisionEvent.PlayerCollisionEvent += AutoRunActivator;
    }

    void AutoRunActivator()
    {
        gameObject.GetComponent<chaserPositionLocked>().enabled = false;
        gameObject.transform.position = target.transform.position + offset;
        gameObject.transform.Rotate(ROffset);
        anim.SetTrigger("chaserIdle");
    }
}
