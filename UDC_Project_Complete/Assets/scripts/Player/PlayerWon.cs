using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWon : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        GateLiftUpEvent.thisGateLiftUpEvent.finishLineCrossed += PlayerCelebration;
    }

    void PlayerCelebration()
    {
        gameObject.GetComponent<RunNdTurn>().enabled = false;
        anim.SetTrigger("FinishLine");
    }

}
