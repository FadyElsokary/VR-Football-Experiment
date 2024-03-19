using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public GameManager Gamemanager;
    public AddVelocity addvelocity1;
    public AddVelocity addvelocity2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            addvelocity1.stopcounter = true;
            addvelocity2.stopcounter = true;
            other.gameObject.tag = "Untagged";
            Gamemanager.GoalIn1();
        }
    }

}
