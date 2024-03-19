using UnityEngine;
using UnityEngine.UI;

namespace Valve.VR.InteractionSystem
{
    public class menuopen2 : MonoBehaviour
    {
        public SteamVR_Input_Sources handType;
        public SteamVR_Action_Boolean menuOpenAction = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("MenuOpen");
        public GameObject menu;
        private bool menustate = false;


        public bool Getmenu()
        {
            return menuOpenAction.GetStateDown(handType);
        }

        void Update()
        {
            if (Getmenu())
            {
                if (menustate == false)
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
        }
    }
}
