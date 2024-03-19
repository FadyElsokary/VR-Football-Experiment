using System.Collections;
using UnityEngine;
using Valve.VR.InteractionSystem;
using UnityEngine.SceneManagement;    //Import Scenemanger


public class DoorChangeScene : MonoBehaviour
{
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneName: "Intro_Scene");

        }
    }
}