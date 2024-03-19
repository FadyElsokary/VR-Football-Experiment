using UnityEngine;

public class Hit5 : MonoBehaviour
{
    public GameManager2 gamemanager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "projectile")
        {
            gamemanager.hit5 = true;
        }
    }
}
