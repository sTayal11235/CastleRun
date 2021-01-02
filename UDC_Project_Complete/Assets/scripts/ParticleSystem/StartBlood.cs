using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBlood : MonoBehaviour
{
    ParticleSystem.EmissionModule BloodFountainActivate;
    float emissionDelay;

    // Start is called before the first frame update
    void Start()
    {
        emissionDelay = 0.0f;
        BloodFountainActivate = GetComponent<ParticleSystem>().emission;
    }

    // Update is called once per frame
    void Update()
    {
        if(emissionDelay >= 0.25f && playerCollision.isCollObjSpikes)
        {
            BloodFountainActivate.enabled = true;
        }
        emissionDelay += Time.deltaTime;
    }

}
