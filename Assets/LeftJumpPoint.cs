using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftJumpPoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private float power;
    public Rigidbody rigidbody;
    private bool isJump = false;

    public GameObject landingParticle;

    public bool isParticles = false;

    private void OnTriggerStay(Collider other)
    {
        power = 25;

        if (other.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.Space))
            {
                isJump = true;
                if (!isParticles)
                {
                    isParticles = true;
                }
            }

            if (isJump)
            {
                rigidbody.AddForce(new Vector3(0, 1, 0) * (power * 5));
                rigidbody.AddForce(new Vector3(1, 0, 0) * (power * 2));
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isJump = false;
            isParticles = false;
        }
    }
}
