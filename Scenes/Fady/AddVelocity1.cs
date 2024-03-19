using System.Collections;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class AddVelocity1 : MonoBehaviour
{
    public GameManager Gamemanager;
    public bool elevation;

    //public GameObject leftShoe;
    //public GameObject rightShoe;

    private Vector3 velocity;
    private Vector3 previous;
    public bool stopcounter;


    public Animator GK_animator;
    public string ParameterName = "Dive";

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Debug.Log("I HIT SOMTHING");
        if (collision.gameObject.tag == "Unhitball")
        {
            Debug.Log("I HIT THE BALLLLL !!!!!");

            collision.gameObject.tag = "Ball";
            if (elevation == true)
            {
                collision.gameObject.GetComponent<Rigidbody>().AddForce(0, velocity.magnitude * 1500, 0);
                elevation = false;
            }
            collision.gameObject.GetComponent<Rigidbody>().velocity = velocity * 2;
            stopcounter = false;
            // StartCoroutine(Countdown());

            Debug.Log("GOALKEEPER TRIGGER IS INTIATE");

            int diveNumber = Random.Range(1, 3); // randomize between 2 animations for Goalkeeper to do {1,2}
            Debug.Log(diveNumber);
            GK_animator.SetInteger(ParameterName, diveNumber);
        }
    }

    private void FixedUpdate()
    {
        velocity = ((transform.position - previous)) / Time.deltaTime;
        previous = transform.position;
        // Update the position of the colliders based on the position of the shoes
        //leftShoe.transform.position = transform.position;
        //rightShoe.transform.position = transform.position;
    }

    //private IEnumerator Countdown() {
    //    float counter = 4f;
    //    while (counter > 0) {
    //        yield return new WaitForSeconds(1);
    //        counter--;
    //    }
    //    if (stopcounter == false) {
    //        Gamemanager.GoalOut1();
    //    }
    //}
}