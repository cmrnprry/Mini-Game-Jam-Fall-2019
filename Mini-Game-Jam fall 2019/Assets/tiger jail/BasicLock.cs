using UnityEngine;
using System.Collections;

public class BasicLock : Lock 

{
    public float moveTime;
    public float moveDistance;
    public Tumbler[] tumblers;

    private bool breakmove = false;

    void Start()
    {
        this.Setup();
        StartCoroutine(Run());
    }

    public override IEnumerator Run()
    {
        while (true)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                yield return StartCoroutine(Move());
            }
            yield return null;
        }
    }

    private IEnumerator Move()
    {
        float t = 0;
        breakmove = false;
        Vector2 startpos = transform.localPosition;
        Vector2 endpos = new Vector2(transform.localPosition.x - moveDistance, transform.localPosition.y);
        while (t / this.moveTime <= 1)
        {
            if (breakmove)
            {
                break;
            }
            transform.localPosition = Vector2.Lerp(startpos, endpos, t / moveTime);
            t += Time.deltaTime;
            yield return null;
        }
        // If move is broken, reverse back to where lock started
        if (breakmove)
        {
            while (t / this.moveTime >= 0)
            {
                transform.localPosition = Vector2.Lerp(startpos, endpos, t / moveTime);
                t -= Time.deltaTime;
                yield return null;
            }
            transform.localPosition = startpos;
        }
        else
        {
            transform.localPosition = endpos;
        }
        
    }

    public override void Setup()
    {
        foreach (Tumbler tumbler in tumblers)
        {
            tumbler.Setup(this);
        }
    }

    [ContextMenu("Test")]
    public void Test()
    {
        StartCoroutine(Run());
    }

    public override void BreakMovement()
    {
        this.breakmove = true;
    }
}
