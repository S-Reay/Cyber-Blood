using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Trooper : Enemy
{
    public float flipTimer = 3f;
    public bool engaged = false;

    void Start()
    {
        StartCoroutine(Countdown());
    }
    public IEnumerator Countdown()
    {
        yield return new WaitForSeconds(flipTimer);
        if (!engaged)
            Flip();
        StartCoroutine(Countdown());
    }

    void Flip()
    {
        transform.eulerAngles += new Vector3(0, 1, 0) * 180f;
    }

}
