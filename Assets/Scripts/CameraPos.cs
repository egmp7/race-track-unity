using UnityEngine;

public class CameraPos : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 cameraOffset;

    void LateUpdate()
    {
        // opposed position to the forward direction of the target
        Vector3 opposedPosition = - target.forward.normalized * cameraOffset.magnitude;

        // move camera position
        transform.position = new Vector3(
            target.position.x + opposedPosition.x,
            target.position.y + cameraOffset.y,
            target.position.z + opposedPosition.z);

        // make the camera look at target
        transform.LookAt(target.position);
    }
}
