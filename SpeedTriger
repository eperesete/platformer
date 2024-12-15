using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTriger : MonoBehaviour
{
    public float multiplikator = 2.5f;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().speed *= multiplikator;
        other.GetComponent<FirstPersonMovement>().runSpeed *= multiplikator;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().speed /= multiplikator;
        other.GetComponent<FirstPersonMovement>().runSpeed /= multiplikator;
    }
}
