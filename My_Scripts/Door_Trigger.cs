using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door_Trigger : MonoBehaviour
{
    public bool doorstate = false;
    public GameObject door1;
    public GameObject door2;
    public Text text1;
    public Text text2;
    private float closed = 7.954758f;
    private float opened1 = 7.053f;
    private float opened2 = 8.856516f;
    void Update()
    {
        if (doorstate == true)
        {
            if (door1.transform.position.x > opened1 && door2.transform.position.x < opened2)
            {
                door1.transform.Translate(0f, 0f, -0.335f * Time.deltaTime);
                door2.transform.Translate(0, 0f, 0.335f * Time.deltaTime);
                text1.GetComponent<RectTransform>().Translate(0.659f * Time.deltaTime, 0f, 0f);
                text2.GetComponent<RectTransform>().Translate(-0.659f * Time.deltaTime, 0f, 0f);
            }
        }
        else
        {
            if (door1.transform.position.x < closed && door2.transform.position.x > closed)
            {
                door2.transform.Translate(0f, 0f, -0.335f * Time.deltaTime);
                door1.transform.Translate(0f, 0f, 0.335f * Time.deltaTime);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            doorstate = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        doorstate = false;
    }
}
