using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodFountainEventTrigger : MonoBehaviour
{

    private void Awake()
    {
        ParticleSystem.EmissionModule bloodFountain = gameObject.GetComponent<ParticleSystem>().emission;
        bloodFountain.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<StartBlood>().enabled = false;
        CollisionEvent.ThisCollisionEvent.PlayerCollisionEvent += enableParticles;
    }

    void enableParticles()
    {
        gameObject.GetComponent<StartBlood>().enabled = true;
    }

}
