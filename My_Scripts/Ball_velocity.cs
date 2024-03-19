using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_velocity : MonoBehaviour
{

    [SerializeField] int speed;

    private void OnCollisionEnter(UnityEngine.Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * speed, ForceMode.Impulse);
        }
    }

}
