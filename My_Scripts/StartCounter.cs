using UnityEngine;

public class StartCounter : MonoBehaviour
{
    public GameManager2 gamemanager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "projectile")
        {
            if (gamemanager.skipped == false)
            {
                gamemanager.HoopThrown();
                gamemanager.skipped = true;
            }
        }      
    }
}
