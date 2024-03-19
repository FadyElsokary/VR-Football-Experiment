using VR = UnityEngine.XR;
using UnityEngine;
using UnityEngine.XR;

//using Mirror;
public class StopPos1 : MonoBehaviour     //For Position of the Camera in the VR to Follow Body and Hands to Follow hands
{
    public GameObject head;
    public GameObject LeftHand;
    // private  device;
    public Vector3 Offset;
    public Vector3 Offset2;
    public GameObject RightHand;
    //public GameObject LeftController;
    //public GameObject RightController;
    public float offset;
    public GameObject midNoseBridge;
    public GameObject hips;
    // public GameObject PlayerPrefab;
    //  private SteamVR_Controller.Device Controller;
    // Start is called before the first frame update
    public static float pos;
    //public GameObject LeftAvatarHand, RightAvatarHand;

    private GameObject PlayerPrefab;
    private GameObject LeftController, RightController;
    //public override void OnStartLocalPlayer()
    //{
     //   Valve.VR.OpenVR.System.ResetSeatedZeroPose();
      //  InputTracking.disablePositionalTracking = true;
    
                  // UnityEngine.VR.InputTracking.disablePositionalTracking = true;
    //   // LeftController = GameObject.FindGameObjectWithTag("LeftController");
    //    //RightController = GameObject.FindGameObjectWithTag("RightController");
    //    // if (!hasAuthority) { return; }
       // Valve.VR.OpenVR.System.ResetSeatedZeroPose();
    //    // InputTracking.Recenter();
    //    //Valve.VR.OpenVR.Compositor.SetTrackingSpace(Valve.VR.ETrackingUniverseOrigin.TrackingUniverseSeated);


    //    //   pos = MyCamera.transform.position.y - this.transform.position.y;



    //    //Vector3 midnose = midNoseBridge.transform.position;
    //    //MyCamera.transform.position = new Vector3(midNoseBridge.transform.position.x, midNoseBridge.transform.position.y, midNoseBridge.transform.position.z);
    //    //// head.transform.rotation = MyCamera.transform.rotation;

    //    // MyCamera.transform.forward = midNoseBridge.transform.forward;
    //    // //Vector3 hipsPos = hips.transform.position;
    //    // pos = MyCamera.transform.position.y -this.transform.position.y;
    //    // //PlayerPrefab.transform.position = new Vector3(hipsPos.x + 0.19f, hipsPos.y - 0.95f, hipsPos.z + 0.66f);



    //}
    void Start()
    {
        PlayerPrefab = GameObject.FindGameObjectWithTag("steamVRPlayer");
        //head.transform.rotation = MyCamera.transform.rotation;
        LeftController = GameObject.FindGameObjectWithTag("LeftController");
        RightController = GameObject.FindGameObjectWithTag("RightController");
        SetControllersToHands();

        UpdatePositions();

        //PlayerPrefab.transform.position = new Vector3(hipsPos.x-0.120f, hipsPos.y - 0.95f, hipsPos.z -0.07f);

        //PlayerPrefab.transform.position = new Vector3(hipsPos.x-0.19f, hipsPos.y - 0.88f, hipsPos.z + 0.37f);
        //transform.position = -InputTracking.GetLocalPosition(XRNode.LeftHand);
        //  transform.position = -InputTracking.GetLocalPosition(XRNode.RightHand);


        //PlayerPrefab.transform.position = new Vector3(hipsPos.x , hipsPos.y, hipsPos.z );
    }

    void UpdatePositions()
    {
        //Vector3 hipsPos = hips.transform.position;
        //PlayerPrefab.transform.position = new Vector3(hipsPos.x, hipsPos.y, hipsPos.z);
        //Offset = new Vector3(0.1f,0,0.1f);
        //Offset2 = new Vector3(0, 0, 0);
        if (RightController != null) { RightController.transform.localPosition = Vector3.zero; }
        if (LeftController != null) { LeftController.transform.localPosition = Vector3.zero; }

    }

    void SetControllersToHands()
    {
        if (LeftController != null) { LeftController.transform.SetParent(LeftHand.transform); }
        if (RightController != null) { RightController.transform.SetParent(RightHand.transform); }

    }

    // Update is called once per frame
    void Update()
    {
        //{/////////noraaaaaaa
        // if (!hasAuthority) { return; }


        // this.transform.position =;


        //  head.transform.rotation = MyCamera.transform.rotation;

        // Vector3 hipsPos = hips.transform.position;
        //
        // GameObject PlayerPrefab = GameObject.FindGameObjectWithTag("steamVRPlayer");
        Camera MyCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
		
        MyCamera.transform.position = new Vector3(midNoseBridge.transform.position.x, midNoseBridge.transform.position.y, midNoseBridge.transform.position.z);


    }

    private void LateUpdate()
    {  //    //////////noraaaa

        //Vector3 PosOfLeftHand = LeftHand.transform.position;
        //Vector3 PosOfRightHand = RightHand.transform.position;



        //if (RightController != null)
        //{

        //    RightController.transform.position = new Vector3(PosOfRightHand.x, PosOfRightHand.y , PosOfRightHand.z  );
        //}


        //if (LeftController != null)
        //{
        //    LeftController.transform.position = new Vector3(PosOfLeftHand.x , PosOfLeftHand.y , PosOfLeftHand.z );
        //}
        //UpdatePositions();

        //}
        //Camera MyCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        //this.transform.position = new Vector3(MyCamera.transform.position.x,MyCamera.transform.position.y-pos,MyCamera.transform.position.z);
    }
}
