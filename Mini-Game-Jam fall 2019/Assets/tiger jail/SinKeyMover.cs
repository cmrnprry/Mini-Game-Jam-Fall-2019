using UnityEngine;
using System.Collections;

public class SinKeyMover : KeyMover
{
    private float t = 0;
    public float amplitude;
    public float period;
    public Transform key;

    private bool moving;

    void Start()
    {
        StartMovement();
    }

    private IEnumerator MoveKey()
    {
        moving = true;
        while (moving)
        {
            key.localPosition = new Vector2(0, amplitude * Mathf.Cos(((Mathf.PI * 2) / this.period) * this.t));
            t += Time.deltaTime;
            //t = t % (period * Mathf.PI * 2);
            yield return null;
        }
    }

    [ContextMenu("StartBounce")]
    public override void StartMovement()
    {
        StartCoroutine(MoveKey());
    }

    public override void StopMovement()
    {
        this.moving = false;
    }

    public override void ResetMovement()
    {
        this.t = 0;
        key.localPosition = Vector2.zero;
    }
}
