using UnityEngine;

public class StartCounter2 : MonoBehaviour
{
    public GameManager2 gamemanager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "projectile")
        {
            if (gamemanager.skipped == false) {
                gamemanager.RockThrown();
                gamemanager.skipped = true;
            }
        }
    }
}
