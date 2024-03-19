using System.Collections;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class AddVelocity : MonoBehaviour
{
    public GameManager Gamemanager;
    public bool elevation;
    private Vector3 velocity;
    private Vector3 previous;
    public bool stopcounter;



    private void OnCollisionEnter(UnityEngine.Collision other) {
        if (other.gameObject.tag == "Unhitball") {
            Debug.Log("I HIT THE BALL");
            other.gameObject.tag = "Ball";
            if(elevation == true) {
                other.gameObject.GetComponent<Rigidbody>().AddForce(0,velocity.magnitude*15,0);
                elevation = false;
            }
            other.gameObject.GetComponent<Rigidbody>().velocity = velocity*4;
            stopcounter = false;

            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            Vector3 v3Velocity = rb.velocity;
            Debug.Log(v3Velocity);
            // StartCoroutine(Countdown());
        }
    }

    private void FixedUpdate()
    {
        velocity = ((transform.position - previous)) / Time.deltaTime;
        previous = transform.position;
    }

    private IEnumerator Countdown() {
        float counter = 4f;
        while (counter > 0) {
            yield return new WaitForSeconds(1);
            counter--;
        }
        if (stopcounter == false) {
            Gamemanager.GoalOut1();
        }
    }
}
