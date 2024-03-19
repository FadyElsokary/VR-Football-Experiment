using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attach_Clothes : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        bool w = Input.GetKey(KeyCode.W);
        if (w)
        {
            Vector3 move = new Vector3(0, 0, 1) * speed * Time.deltaTime;
            rb.MovePosition(transform.position + move);
        }
    }
}
