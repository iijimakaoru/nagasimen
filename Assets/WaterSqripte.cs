using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSqripte : MonoBehaviour
{
    public bool isInWater = false;

    private void Update()
    {
        Debug.Log(isInWater);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInWater = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInWater = false;
        }
    }
}
