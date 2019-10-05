using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    float nextFlip = 0.2f;
    int currentFrame = 0;
    SpriteRenderer sr;
    public Sprite[] frames = new Sprite[2];

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFlip)
        {
            if (currentFrame == 0)
            {
                currentFrame = 1;
            }
            else
            {
                currentFrame = 0;
            }
            sr.sprite = frames[currentFrame];
            nextFlip += 0.2f;
        }
    }
}
