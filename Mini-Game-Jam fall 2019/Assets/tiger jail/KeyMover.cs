using UnityEngine;
using UnityEditor;

/// <summary>
/// Attach to key container, controls movement of key in a certain repeating pattern
/// </summary>
public abstract class KeyMover : MonoBehaviour
{
    public abstract void StartMovement();

    public abstract void StopMovement();

    public abstract void ResetMovement();
}