using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DD_PointConstraint : MonoBehaviour
{
    public Transform point;

    void Update()
    {
        transform.position = point.transform.position;
    }
}
