using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlesPro : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    public PlayerController playerController;
    public LeftJumpPoint left;
    public RightJumpPoint right;
    public GameObject landingParticle;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
        if (left.isParticles || right.isParticles || playerController.isParticles)
        {
            Instantiate(landingParticle,
                    new Vector3(transform.position.x,
                    transform.position.y,
                    transform.position.z),
                    Quaternion.identity);
            if (left.isParticles)
            {
                left.isParticles = false;
            }

            if (right.isParticles)
            {
                right.isParticles = false;
            }

            if (playerController.isParticles)
            {
                playerController.isParticles = false;
            }
        }
    }
}
