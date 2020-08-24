using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragGrenade : MonoBehaviour
{
    public float delay;
    private float countdown;
    private bool hasExploded;

    public GameObject explosionEffect;

    void Start()
    {
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }
    }
    void Explode()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        //Get nearby objects

        Destroy(gameObject);
    }
}
