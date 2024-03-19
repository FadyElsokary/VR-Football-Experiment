using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Valve.VR.InteractionSystem
{
    public class Menuopen : MonoBehaviour
    {
        public SteamVR_Input_Sources handType;
        public SteamVR_Action_Boolean menuOpenAction = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("MenuOpen");
        public SteamVR_Action_Boolean TeleportAction = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("Teleport");
        public GameObject menu;
        public GameObject room;
        public GameObject Door_Collider;
        public GameObject Stadnoise;
        public GameObject Dressingroom;
        public AudioSource whistle;
        public Text currentlevel;
        private bool menustate = false;
        private bool move = false;
        private int stage = 1;
        public GameObject object1;
        public GameObject object2;
        public GameObject object3;
        public GameObject object4;
        public GameObject object5;
        public GameObject object6;
        public GameObject object7;
        public GameObject object8;


        public bool Getmenu()
        {
            return menuOpenAction.GetStateDown(handType);
        }

        public bool GetTp()
        {
            return TeleportAction.GetStateDown(handType);
        }

        void Update()
        {
            if (Getmenu())
            {
                if(menustate == false)
                {
                    menu.SetActive(true);
                    menustate = true;
                }
                else
                {
                    menu.SetActive(false);
                    menustate = false;
                }
            }

            if (GetTp())
            {
                if (stage == 1) {
                    room.transform.position = new Vector3(2.46f, -2.900529f, 26.15f);
                    stage = 2;
                    StartCoroutine(Countup());
                }
                else if (stage == 2)
                {
                    if(move == true) {
                        room.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
                        room.transform.position = new Vector3(5.26f, -2.900529f, 39.94f);
                        stage = 3;
                    }
                }
                else if (stage == 3)
                {
                    Door_Collider.SetActive(false);
                    object1.SetActive(false);
                    object2.SetActive(false);
                    object3.SetActive(false);
                    object4.SetActive(false);
                    object5.SetActive(false);
                    object6.SetActive(false);
                    object7.SetActive(false);
                    object8.SetActive(false);
                    room.transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
                    room.transform.position = new Vector3(-61.7f, -2.900529f, 35.7f);
                    stage = 4;
                    currentlevel.text = "Current Level: Penalty Kicks";
                    Stadnoise.SetActive(true);
                    Destroy(Dressingroom);
                    whistle.Play();
                }
            }
        }

        private IEnumerator Countup() {
            float counter = 30f;
            while (counter > 0) {
                yield return new WaitForSeconds(1);
                counter--;
            }
            move = true;
        }
    }
}
