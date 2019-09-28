using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protecc_TigerController : MonoBehaviour
{
    public int score;
    public float speed;
    public bool isAccelerating;
    public float accelerationForce;

    private Rigidbody2D rb; // gives control of this sprite to the Unity physics engine

    // Start is called before the first frame update, when the sprite is created.
    void Start()
    {
        // Access components that were added to the sprite in Unity.
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // FixedUpdate is frame-rate independent, used for Unity physics calculations.
    private void FixedUpdate()
    {
        if (isAccelerating)
        {
            // Add force to the sprite to move it forward...
            rb.AddForce(Vector2.right * accelerationForce);
        }
        else
        {
            // Set the sprite's velocity to a constant speed...
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        score++;
    }

    // OnTriggerEnter is called once when a collider on this sprite enters a trigger collider.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If the Sprite collides with our Finish checkpoint...
        if (collision.gameObject.CompareTag("Finish"))
        {
            // Sprite stops moving...
            rb.velocity = Vector2.zero;

            // Load the next mini game...
        }

    }
}
