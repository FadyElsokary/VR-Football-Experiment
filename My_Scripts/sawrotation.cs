using UnityEngine;

public class sawrotation : MonoBehaviour
{
    public GameObject mid;
    void Update()
    {
        Vector3 center = mid.transform.position;
        Vector3 axis = new Vector3(1, 0, 0);
        this.transform.RotateAround(center, axis, -45);
    }
}
