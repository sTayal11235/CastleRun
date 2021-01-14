using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    Animator anim;
    public static bool isCollObjSpikes;
    // Start is called before the first frame update
    void Start()
    {
        isCollObjSpikes = false;
        CollisionEvent.ThisCollisionEvent.PlayerCollisionEvent += PlayerAnimExecution;
        anim = gameObject.GetComponent<Animator>();
    }

    void PlayerAnimExecution()
    {
        gameObject.GetComponent<RunNdTurn>().enabled = false;
        anim.SetTrigger("hitObstacle");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            isCollObjSpikes = true;
        }
    }
}
