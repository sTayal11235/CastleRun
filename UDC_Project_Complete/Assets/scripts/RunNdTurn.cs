using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunNdTurn : MonoBehaviour
{

    [SerializeField]
    Rigidbody myCharacter;

    Vector3 runSpeed = new Vector3(0, -5.0f, 7.5f);

    float rotationAngleY;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<RunTimeKeeper>().enabled = false;
        myCharacter = GetComponent<Rigidbody>();
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
            this.FixedUpdate();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            myCharacter.velocity = new Vector3(0, 0, 0);
            rotationAngleY -= 90.0f;
            myCharacter.rotation = Quaternion.Euler(0, rotationAngleY, 0);
            this.FixedUpdate();
        }

    }

    void FixedUpdate()
    {
        myCharacter.velocity = runSpeed;
    }
}
