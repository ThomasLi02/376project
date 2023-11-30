using UnityEngine;

public class SphereCarController : MonoBehaviour
{
    public float speed = 10f; // Speed of the sphere car
    public float turnSpeed = 100f; // Turn speed of the sphere car

    private Rigidbody rb; // Rigidbody component for physics

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody component
    }

    void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical"); // Get input from up/down arrow keys or W/S keys
        float moveHorizontal = Input.GetAxis("Horizontal"); // Get input from left/right arrow keys or A/D keys

        Vector3 movement = transform.forward * moveVertical * speed * Time.deltaTime; // Calculate forward movement
        Quaternion turn = Quaternion.Euler(0f, moveHorizontal * turnSpeed * Time.deltaTime, 0f); // Calculate turn rotation

        rb.MovePosition(rb.position + movement); // Apply forward movement
        rb.MoveRotation(rb.rotation * turn); // Apply turning
    }
}
