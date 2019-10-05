using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody rb;

    public float speed = 10f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        rb.MovePosition(transform.position + new Vector3(speed * horiz,0,speed * vert) * Time.fixedDeltaTime * speed);
        
    }
}
