using UnityEngine;

public class BoatController : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 100.0f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Move the boat forward or backward
        Vector2 movement = transform.up * verticalInput * speed;
        rb.AddForce(movement);

        // Calculate the angle of rotation based on the input direction
        float rotationAngle = -horizontalInput * rotationSpeed * Time.fixedDeltaTime;
        Quaternion rotation = Quaternion.Euler(0, 0, rotationAngle);

        // Rotate the boat relative to its facing direction
        rb.MoveRotation(rb.rotation + rotation.eulerAngles.z);
    }
}