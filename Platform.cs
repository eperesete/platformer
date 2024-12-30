using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Transform Point1;
    public Transform Point2;
    public float speed;
    private float speed_y = 0;
    private bool toPoint2 = false;

    void OnTriggerStay(Collider other)
    {
        toPoint2 = true;
        Vector3 pos1 = transform.position;
        transform.position = Vector3.MoveTowards(transform.position, Point2.position, speed * Time.deltaTime);
        pos1 = transform.position - pos1;
        other.transform.position += pos1;
    }
    void OnTriggerExit()
    {
        toPoint2 = false;
    }

    void Update()
    {
        if (!toPoint2)
        {
            transform.position = Vector3.MoveTowards(transform.position, Point1.position, speed * Time.deltaTime);
        }
    }
}
