using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float rotateSpeed;

    private Vector3 _initPos;
    private Quaternion _initRot;

    private void OnEnable()
    {
        EventManager.onPlayerDeath += ResetPlayerPosition;
    }
    private void OnDisable()
    {
        EventManager.onPlayerDeath -= ResetPlayerPosition;
    }

    private void Start()
    {
        _initPos = transform.position;
        _initRot = transform.rotation;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        // Inputs
        float movement = Input.GetAxisRaw("Vertical");
        float turn = Input.GetAxisRaw("Horizontal");

        // Calculate movement and rotation
        Vector3 newPos = new Vector3(0, 0, movement) * movementSpeed * Time.deltaTime;
        Vector3 newRot = new Vector3(0, turn, 0) * rotateSpeed * Time.deltaTime;

        // Move
        transform.Translate(newPos);
        transform.Rotate(newRot);
    }

    private void ResetPlayerPosition()
    {
        transform.position = _initPos;
        transform.rotation = _initRot;
    }
}
