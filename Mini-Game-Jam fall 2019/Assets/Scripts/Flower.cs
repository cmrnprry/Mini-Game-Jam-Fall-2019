using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    float next = 0.05f;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > next && Time.time < 1.25)
        {
            if (sr.enabled)
            {
                sr.enabled = false;
            }
            else
            {
                sr.enabled = true;
            }
            next += 0.05f;
        }

        if (Time.time > 1.25)
        {
            sr.enabled = true;
        }
    }
}
