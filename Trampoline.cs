using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float multiplikator = 10f;

    void OnTriggerEnter(Collider other)
    {
        //����������� ���� ������
        other.GetComponent<Jump>().jumpStrength *= multiplikator;
    }

    void OnTriggerExit(Collider other)
    {
        //��������� ���� ������
        other.GetComponent<Jump>().jumpStrength /= multiplikator;
    }
}
