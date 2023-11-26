using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float rotateSpeed;

    void Update()
    {
        // Inputs
        float movement = Input.GetAxisRaw("Vertical");
        float turn = Input.GetAxisRaw("Horizontal");

        // Calculate movement and rotation
        Vector3 newPos = new Vector3(0,0,movement) * movementSpeed * Time.deltaTime;
        Vector3 newRot = new Vector3(0, turn, 0) * rotateSpeed * Time.deltaTime;

        // Move
        transform.Translate(newPos);
        transform.Rotate(newRot);
    }
}
