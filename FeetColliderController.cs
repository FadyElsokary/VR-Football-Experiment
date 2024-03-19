using UnityEngine;

public class FeetColliderController : MonoBehaviour
{
    public GameObject playerObject; // The player object with the humanoid rig
    public float colliderHeight; // The height of the collider above the feet

    private Transform leftFoot; // The left foot bone
    private Transform rightFoot; // The right foot bone
    private GameObject leftFootCollider; // The left foot collider
    private GameObject rightFootCollider; // The right foot collider

    void Start()
    {
        // Get the left and right foot bones from the player object's humanoid rig
        leftFoot = playerObject.GetComponent<Animator>().GetBoneTransform(HumanBodyBones.LeftFoot);
        rightFoot = playerObject.GetComponent<Animator>().GetBoneTransform(HumanBodyBones.RightFoot);

        // Create the left and right foot colliders and attach them to the foot bones
        leftFootCollider = new GameObject("Left Foot Collider");
        leftFootCollider.transform.parent = leftFoot;
        leftFootCollider.transform.localPosition = Vector3.zero;
        leftFootCollider.AddComponent<BoxCollider>();
        leftFootCollider.GetComponent<BoxCollider>().size = new Vector3(0.2f, 0.1f, 0.2f);
        leftFootCollider.GetComponent<BoxCollider>().center = new Vector3(0, colliderHeight, 0);


        rightFootCollider = new GameObject("Right Foot Collider");
        rightFootCollider.transform.parent = rightFoot;
        rightFootCollider.transform.localPosition = Vector3.zero;
        rightFootCollider.AddComponent<BoxCollider>();
        rightFootCollider.GetComponent<BoxCollider>().size = new Vector3(0.2f, 0.1f, 0.2f);
        rightFootCollider.GetComponent<BoxCollider>().center = new Vector3(0, colliderHeight, 0);

    }
}