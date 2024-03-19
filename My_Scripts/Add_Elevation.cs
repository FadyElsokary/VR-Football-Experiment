using System.Collections;
using UnityEngine;

public class Add_Elevation : MonoBehaviour
{
    public AddVelocity addvelocity1;
    public AddVelocity addvelocity2;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag != "Unhitball")
        {
            addvelocity1.elevation = true;
            addvelocity2.elevation = true;
        }
    }
}
