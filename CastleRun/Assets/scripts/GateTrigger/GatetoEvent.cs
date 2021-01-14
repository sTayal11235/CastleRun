using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatetoEvent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GateLiftUpEvent.thisGateLiftUpEvent.finishLineCrossed += Enabeler;
    }

    void Enabeler()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponent<GateLifting>().enabled = true;
    }

}
