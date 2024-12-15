using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float multiplikator = 10f;

    void OnTriggerEnter(Collider other)
    {
        //увеличивыет силу прыжка
        other.GetComponent<Jump>().jumpStrength *= multiplikator;
    }

    void OnTriggerExit(Collider other)
    {
        //уменьшает силу прыжка
        other.GetComponent<Jump>().jumpStrength /= multiplikator;
    }
}
