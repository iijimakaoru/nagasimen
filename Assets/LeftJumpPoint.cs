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

    bool isParticles = false;

    private void OnTriggerStay(Collider other)
    {
        power = 25;

        if (Input.GetKey(KeyCode.Space))
        {
            isJump = true;
            if (!isParticles)
            {
                Instantiate(landingParticle,
                    new Vector3(landingParticle.transform.position.x,
                    landingParticle.transform.position.y,
                    landingParticle.transform.position.z),
                    Quaternion.identity);
                isParticles = true;
            }
        }

        if (isJump)
        {
            rigidbody.AddForce(new Vector3(0, 1, 0) * (power * 4));
            rigidbody.AddForce(new Vector3(1, 0, 0) * (power * 3));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isJump = false;
        isParticles = false;
    }
}
