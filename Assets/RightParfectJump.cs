using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightParfectJump : MonoBehaviour
{
    private float power;
    public Rigidbody rigidbody;
    private bool isJump = false;

    public GameObject landingParticle;

    bool isParticles = false;

    private void OnTriggerStay(Collider other)
    {
        power = 55;

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
            rigidbody.AddForce(new Vector3(0, 1, 0) * power);
            rigidbody.AddForce(new Vector3(-1, 1, 0) * power / 3);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isJump = false;
        isParticles = false;
    }
}
