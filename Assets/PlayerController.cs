using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class PlayerController : MonoBehaviour
{

    private float test = 1;
    private float power = 3;
    private float loundPower = 0.5f;
    public Rigidbody rigidbody;
    private float distance;
    private float fallTimer;

    public GameObject landingParticle;

    bool isLanding = false;

    public bool isParticles = false;

    bool isGround;

    int speedLevel = 1;

    // Start is called before the first frame update
    void Start()
    {
        distance = 0.8f;

        speedLevel = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rayPosition = transform.position + new Vector3(0.0f, 0.0f, 0.0f);
        Ray ray = new Ray(rayPosition, Vector3.down);
        isGround = Physics.Raycast(ray, distance);
        Debug.DrawRay(rayPosition, Vector3.down * distance, Color.red);

        rigidbody.AddForce(new Vector3(0, 0, 1) * loundPower);

        if (isGround)
        {
            if (!isLanding)
            {
                if (!isParticles)
                {
                    isParticles = true;
                }
                isLanding = true;
            }

            fallTimer = 60;

            if (Input.GetKey(KeyCode.RightArrow))
            {
                rigidbody.AddForce(new Vector3(1, 0, 0) * power);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rigidbody.AddForce(new Vector3(-1, 0, 0) * power);
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                if (speedLevel > 1)
                {
                    speedLevel--;
                }
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                if (speedLevel < 3)
                {
                    speedLevel++;
                }
            }

            if (speedLevel == 1)
            {
                loundPower = 0.5f;
            }
            else if (speedLevel == 2)
            {
                loundPower = 1.5f;
            }
            else if (speedLevel == 3)
            {
                loundPower = 2.5f;
            }
            else
            {
                loundPower = 0;
            }
        }
        else
        {
            fallTimer--;
            if (fallTimer < 0)
            {
                rigidbody.AddForce(new Vector3(0, -1, 0) * power / 2);
            }
            isLanding = false;
        }
    }
}
