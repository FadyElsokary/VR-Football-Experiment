using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocksCounter : MonoBehaviour
{
    public GameManager2 gamemanger;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Cup")
        {
            other.gameObject.tag = "fallencup";
            gamemanger.fallenrocks++;
        }
    }
}
