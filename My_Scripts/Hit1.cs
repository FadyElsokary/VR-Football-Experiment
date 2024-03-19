using UnityEngine;

public class Hit1 : MonoBehaviour
{
    public GameManager2 gamemanager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "projectile")
        {
            gamemanager.hit1 = true;
        }
    }
}
