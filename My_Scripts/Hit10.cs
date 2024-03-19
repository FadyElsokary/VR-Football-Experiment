using UnityEngine;

public class Hit10 : MonoBehaviour
{
    public GameManager2 gamemanager;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "projectile")
        {
            gamemanager.hit10 = true;
        }
    }
}
