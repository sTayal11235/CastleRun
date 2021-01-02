using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMenu : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<GameOverFunctions>().enabled = false;
        CollisionEvent.ThisCollisionEvent.PlayerCollisionEvent += GameOverScript;
        NoFloorFallingEvent.thisNoFloorFallingEvent.noPlatformBelow += GameOverScript;

    }

    void GameOverScript()
    {
        gameObject.GetComponent<GameOverFunctions>().enabled = true;
    }
}
