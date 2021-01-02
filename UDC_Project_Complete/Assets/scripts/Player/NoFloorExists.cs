using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoFloorExists : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        NoFloorFallingEvent.thisNoFloorFallingEvent.noPlatformBelow += PlayerFallingAnim;
    }

    void PlayerFallingAnim()
    {
        gameObject.GetComponent<RunNdTurn>().enabled = false;
        anim.SetTrigger("NoFloor");
    }
}
