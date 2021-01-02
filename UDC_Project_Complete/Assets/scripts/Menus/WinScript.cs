using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<YouWinAfterPause>().enabled = false;
        GateLiftUpEvent.thisGateLiftUpEvent.finishLineCrossed += Win;
    }

    void Win()
    {
        gameObject.GetComponent<YouWinAfterPause>().enabled = true;
    }

}
