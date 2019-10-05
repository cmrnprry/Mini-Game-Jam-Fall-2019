using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    public Sprite[] sprites = new Sprite[3];
    SpriteRenderer sr;
    GameObject buttons;
    GameObject directions;

    // Start is called before the first frame update
    void Start()
    {
        int spriteNum = Random.Range(0, 3);
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = sprites[spriteNum];
        sr.color = Color.black;

        buttons = GameObject.Find("Buttons");
        directions = GameObject.Find("Directions");
        buttons.SetActive(false);
        directions.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 1)
        {
            sr.color = Color.white;
            buttons.SetActive(true);
            directions.SetActive(true);
        }
    }
}
