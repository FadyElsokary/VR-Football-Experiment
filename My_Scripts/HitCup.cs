
using UnityEngine;

public class HitCup : MonoBehaviour
{

    public AudioSource hitcup;
    private void OnCollisionEnter(UnityEngine.Collision other)
    {
        if(other.gameObject.tag == "Cup")
        {
            hitcup.Play();
        }
    }
}
