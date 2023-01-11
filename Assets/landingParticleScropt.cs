using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landingParticleScropt : MonoBehaviour
{
    private ParticleSystem ps;

    private PlayerController gameObject;

    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        gameObject = GameObject.Find("player").GetComponent<PlayerController>();
        ps.trigger.SetCollider(0, gameObject.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
