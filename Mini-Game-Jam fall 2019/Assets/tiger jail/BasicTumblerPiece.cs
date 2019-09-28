using UnityEngine;
using System.Collections;

public class BasicTumblerPiece : TumblerPiece
{
    private Tumbler tumbler;
    public override void Setup(Tumbler signal)
    {
        this.tumbler = signal;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        this.tumbler.Collision();
    }
}
