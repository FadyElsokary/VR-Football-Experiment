using UnityEngine;

public class stickonhit : MonoBehaviour
{
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "projectile")
        {
            collision.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
            collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
