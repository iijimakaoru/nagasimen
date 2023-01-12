using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterParticleScript : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    public GameObject waterParticle;

    public WaterSqripte waterSqripte;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
