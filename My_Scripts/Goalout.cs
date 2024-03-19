using UnityEngine;

public class Goalout : MonoBehaviour
{
    public GameManager Gamemanager;
    public bool timeout = false;
    public bool currentball = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball" && currentball == false)
        {
            other.gameObject.tag = "Untagged";
            if (timeout == false) {
                Gamemanager.GoalOut1();
                currentball = true;
            }
        }
    }
}
