using UnityEngine;
using System.Collections;

public abstract class Lock : MonoBehaviour
{
    public abstract void Setup();
    public abstract void BreakMovement();
    public abstract IEnumerator Run();
}
