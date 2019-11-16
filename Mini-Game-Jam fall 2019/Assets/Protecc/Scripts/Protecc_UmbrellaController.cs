using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protecc_UmbrellaController : MonoBehaviour
{
    public float offset = 15f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = offset;
            // Debug.Log(Camera.main.ScreenToWorldPoint(mousePos));
            rb.MovePosition(Camera.main.ScreenToWorldPoint(mousePos));
        }
    }
}
