using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
// Script for managing the rope the player has to jump over in the Jump Rope minigame
public class JRRope : MonoBehaviour
{
    // Animation curve to aid in moving of rope based on animation
    public AnimationCurve animCurve;
    // Vector3 to add force to the jump rope (swing it downward)

    // Runs on startup, sets certain private variables
    void Start()
    {

    }

    // Runs every frame, handles user input
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            Swing();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

        }
    }

    void Swing()
    {

    }
}
