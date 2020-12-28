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
    float coolDown = 0.0f;

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
        
        //Quaternion rotateMyCharacter = Quaternion.Euler(0, rotationAngleY, 0);
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

        if(Input.GetKeyDown(KeyCode.Space) && coolDown >= 1.0f)
        {
            JumpUp();
            coolDown = 0.0f;
        }

        coolDown += Time.deltaTime;
    }

    void FixedUpdate()
    {
        if(myCharacter.rotation.eulerAngles.y >= 85 && myCharacter.rotation.eulerAngles.y < 95)
        {
            runSpeed = new Vector3(speed, - 8.0f, 0.0f);            
            Debug.Log("X");
        }

        else if(myCharacter.rotation.eulerAngles.y >= 175 && myCharacter.rotation.eulerAngles.y < 185)
        {
            runSpeed = new Vector3(0.0f, -8.0f, -1 * speed);
            Debug.Log("-Z");
        }
        else if(myCharacter.rotation.eulerAngles.y >= 265 && myCharacter.rotation.eulerAngles.y < 275)
        {
            runSpeed = new Vector3(-1 * speed, -8.0f, 0.0f);
            Debug.Log("-X");
        }
        else
        {
            runSpeed = new Vector3(0.0f, -8.0f, speed);
            Debug.Log("Z");
        }

        myCharacter.velocity = runSpeed;
    }

    void JumpUp()
    {
        Vector3 liftUp = new Vector3(runSpeed.x * 10, 200.0f, runSpeed.z * 10);
        myCharacter.AddForce(liftUp, ForceMode.Impulse);
    }
}
