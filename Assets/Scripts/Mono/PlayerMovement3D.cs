using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    private bool isGrounded;

    private Rigidbody rb;
    private Vector3 movement;

    void Start() => rb = GetComponent<Rigidbody>();

    void Update()
    {
        // Get input for horizontal and vertical movement
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        movement = new Vector3(moveX * moveSpeed, rb.velocity.y, moveZ * moveSpeed);

        // Check if the player is grounded and the jump button is pressed
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(new Vector3(0f, jumpForce, 0f), ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        // Apply the movement to the Rigidbody
        Vector3 velocity = rb.velocity;
        velocity.x = movement.x;
        velocity.z = movement.z;
        rb.velocity = velocity;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the player is grounded
        if (collision.contacts[0].normal.y > 0.5f)
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // Check if the player is no longer grounded
        if (collision.contacts[0].normal.y > 0.5f)
        {
            isGrounded = false;
        }
    }
}
