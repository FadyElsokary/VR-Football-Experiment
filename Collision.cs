using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    
    public float pushforce = 1;

    private void OnControllerColliderHit(ControllerColliderHit hit)

    {
        Rigidbody _rigg = hit.collider.attachedRigidbody;

        if(_rigg != null)
        {
            Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
            forceDirection.Normalize();

            _rigg.AddForceAtPosition(forceDirection * pushforce, transform.position, ForceMode.Impulse);

        }

    }




}
