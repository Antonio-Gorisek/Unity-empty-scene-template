using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    private bool isGrounded;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start() => rb = GetComponent<Rigidbody2D>();

    void Update()
    {
        // Get input for horizontal movement
        float moveX = Input.GetAxis("Horizontal");
        movement = new Vector2(moveX * moveSpeed, rb.velocity.y);

        // Check if the player is grounded
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    void FixedUpdate()
    {
        // Apply the movement to the Rigidbody2D
        rb.velocity = movement;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player is grounded
        if (collision.contacts[0].normal.y > 0.5f)
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        // Check if the player is no longer grounded
        if (collision.contacts[0].normal.y > 0.5f)
        {
            isGrounded = false;
        }
    }
}
