using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goalkeeper_movement : MonoBehaviour
{
    
    public Animator animator;
    public string ParameterName = "Dive";



    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            

            int diveNumber = Random.Range(1, 3); // randomize between 2 animations for Goalkeeper to do
            Debug.Log("Goal keeper dive number is "+diveNumber);
            animator.SetInteger(ParameterName, diveNumber);
            
        }
    }

}
