using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
// Script to handle controlling the player in the Jump Rope minigame
public class JRController : MonoBehaviour
{
    // Player's Rigidbody2D component for accepting forces
    private Rigidbody2D rb2d;
    // Jump vector to add force to player's Rigidbody2D component
    private Vector3 jumpVec;
    // private variable for checking if player is grounded
    private bool isGrounded;
    // public float value for tweaking the amount of force the player can jump off the ground with
    public float jumpForce;

    // Runs on startup, sets certain private variables
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        jumpVec = new Vector3(0.0f, 1.0f, 0.0f);
    }

    // Runs when player collides with another collider
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // When player collides with ground, run Land() method
        Land();
    }

    // Runs every frame, handles user input
    void Update()
    {
        // When player is grounded and presses the space bar, run Jump() method
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    // Method to handle jumping
    void Jump()
    {
        Debug.Log("Jump!");
        // Adds force to player's Rigidbody2D, making them jump into the air
        rb2d.AddForce(jumpVec * jumpForce, ForceMode2D.Impulse);
        // Since they are jumping, they are no longer grounded
        isGrounded = false;
    }

    // Method to handle landing
    void Land()
    {
        Debug.Log("Landed!");
        // Upon landing, the player is grounded again, and can jump again
        isGrounded = true;
    }
}
