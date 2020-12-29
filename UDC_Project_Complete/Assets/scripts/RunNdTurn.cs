using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunNdTurn : MonoBehaviour
{

    [SerializeField]
    Rigidbody myCharacter;

    [SerializeField]
    float speed;

    Vector3 runSpeed;

    float rotationAngleY;
    float noJumpDuration = 0.0f;

    [SerializeField]
    float jumpVel;

    

    // Start is called before the first frame update
    void Start()
    {
        runSpeed = new Vector3(0.0f, -8.0f, speed);
        myCharacter = GetComponent<Rigidbody>();
        gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        rotationAngleY = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.D))
        {
            myCharacter.velocity = new Vector3(0, 0, 0);
            rotationAngleY += 90.0f;
            myCharacter.rotation = Quaternion.Euler(0, rotationAngleY, 0);
            Debug.Log(myCharacter.rotation.eulerAngles.y);
            this.FixedUpdate();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            myCharacter.velocity = new Vector3(0, 0, 0);
            rotationAngleY -= 90.0f;
            myCharacter.rotation = Quaternion.Euler(0, rotationAngleY, 0);
            Debug.Log(myCharacter.rotation.eulerAngles.y);
            this.FixedUpdate();
        }

        if(Input.GetKeyDown(KeyCode.Space) && noJumpDuration >= 0.65f)
        {
            IdleRunDelay.PlayerJumped();
            Jump();
            noJumpDuration = 0.0f;
        }

        noJumpDuration += Time.deltaTime;
    }

    void FixedUpdate()
    {
        if(!IdleRunDelay.JumpedTimerStarted && IdleRunDelay.JumpedTimerEnded)
        {
            if (myCharacter.rotation.eulerAngles.y >= 85 && myCharacter.rotation.eulerAngles.y < 95)
            {
                runSpeed = new Vector3(speed, -1 * speed, 0.0f);
                Debug.Log("X");
            }

            else if (myCharacter.rotation.eulerAngles.y >= 175 && myCharacter.rotation.eulerAngles.y < 185)
            {
                runSpeed = new Vector3(0.0f, -1 * speed, -1 * speed);
                Debug.Log("-Z");
            }
            else if (myCharacter.rotation.eulerAngles.y >= 265 && myCharacter.rotation.eulerAngles.y < 275)
            {
                runSpeed = new Vector3(-1 * speed, -1 * speed, 0.0f);
                Debug.Log("-X");
            }
            else
            {
                runSpeed = new Vector3(0.0f, -1 * speed, speed);
                Debug.Log("Z");
            }

            myCharacter.velocity = runSpeed;
        }
    }

    void Jump()
    {
        float runX = runSpeed.x;
        float runZ = runSpeed.z;
        myCharacter.velocity = new Vector3(runX * 0.75f, jumpVel, runZ * 0.75f);
    }
}
