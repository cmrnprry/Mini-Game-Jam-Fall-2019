using UnityEngine;
using System.Collections;

public class BasicTumbler : Tumbler
{
    private Lock parent;
    public TumblerPiece[] pieces;

    public override void Collision()
    {
        parent.BreakMovement();
    }

    public override void Setup(Lock parent)
    {
        this.parent = parent;
        foreach (TumblerPiece piece in pieces)
        {
            piece.Setup(this);
        }
    }
}
