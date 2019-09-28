using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(CircleCollider2D))]
public class PlayerInput : MonoBehaviour
{
	public float speed = 10f;

	private Rigidbody2D rb;
	private CircleCollider2D ballCollider;
	private bool clickedBall = false;

    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody2D>();
		ballCollider = GetComponent<CircleCollider2D>();

	}

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
		{
			clickedBall = ballCollider.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition));
		}
		else if (Input.GetMouseButton(0) && clickedBall)
		{
			if (ballCollider.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)))
			{
				rb.velocity = Vector2.zero;
			}
			else
			{
				Vector2 forceDir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
				rb.velocity = forceDir.normalized * speed;
			}
		}
		else if (Input.GetMouseButtonUp(0))
		{
			clickedBall = false;
		}
    }
}
