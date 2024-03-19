using UnityEngine;

public class ballout : MonoBehaviour
{
    public practice1manager practice1manager;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Ball") {
            practice1manager.goalout();
        }
    }
}
