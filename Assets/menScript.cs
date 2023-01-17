using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menScript : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    public PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
        if (!playerController.isGround)
        {
            Transform myTransform = this.transform;

            myTransform.Rotate(0, 0, 1.0f);
        }
    }
}
