using UnityEngine;
using System.Collections;

public abstract class Tumbler : MonoBehaviour
{
    public abstract void Setup(Lock parent);

    public abstract void Collision();
}
