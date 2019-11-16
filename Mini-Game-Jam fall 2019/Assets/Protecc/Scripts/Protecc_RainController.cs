using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protecc_RainController : MonoBehaviour
{
    public ParticleSystem part;
    public List<ParticleCollisionEvent> collisionEvents;

    // Start is called before the first frame update, when the sprite is created.
    void Start()
    {
        // Access components that were added to the sprite in Unity.
        part = GetComponent<ParticleSystem>();
        collisionEvents = new List<ParticleCollisionEvent>();
    }

    // OnParticleCollision is called when a particle in this system hits a collider.
    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Tiger"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            Animator anim = other.GetComponent<Animator>();

            anim.SetBool("isHurt", true);
        }
    }
}
