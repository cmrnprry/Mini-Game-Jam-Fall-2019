using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearKeyMover : KeyMover
{
    public GameObject key;
    public float amplitude;
    public float speed;
    private bool goingUp = false;

    private bool bouncing;
    private IEnumerator bounceKey()
    {
        bouncing = true;
        while (bouncing)
        {
            if (goingUp)
            {
                transform.localPosition = new Vector2(0, transform.localPosition.y + Time.deltaTime * speed);
            } else
            {
                transform.localPosition = new Vector2(0, transform.localPosition.y - Time.deltaTime * speed);
            }

            if ((goingUp && transform.localPosition.y > amplitude) || (!goingUp && transform.localPosition.y < -amplitude))
            {
                goingUp = !goingUp;
            }
            yield return null;
        }
    }

    
    public override void StartMovement()
    {
        StartCoroutine(bounceKey());
    }

    public override void StopMovement()
    {
        this.bouncing = false;
    }

    public override void ResetMovement()
    {
        this.goingUp = false;
        transform.localPosition = Vector2.zero;
    }
}
