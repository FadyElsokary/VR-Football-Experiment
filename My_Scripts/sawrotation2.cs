using UnityEngine;

public class sawrotation2 : MonoBehaviour
{
    void Update()
    {
        Vector3 center = new Vector3(0.821f, 1.097f, -3.775f);
        Vector3 axis = new Vector3(1, 0, 0);
        this.transform.RotateAround(center, axis, 45);
    }
}
