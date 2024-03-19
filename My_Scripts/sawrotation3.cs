using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sawrotation3 : MonoBehaviour
{
    void Update()
    {
        Vector3 center = new Vector3(1.036f, 1.097f, -4.015f);
        Vector3 axis = new Vector3(0, 0, 1);
        this.transform.RotateAround(center, axis, -45);
    }
}
