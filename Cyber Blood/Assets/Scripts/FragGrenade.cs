using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragGrenade : MonoBehaviour
{
    public float delay;
    private float countdown;
    private bool hasExploded;

    public float radius = 5f;
    public float force = 700f;

    public GameObject explosionEffect;
    public CameraShake cameraShake;

    void Start()
    {
        countdown = delay;
        cameraShake = Camera.main.GetComponent<CameraShake>();
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
        StartCoroutine(cameraShake.Shake(.2f, .4f));

        Instantiate(explosionEffect, transform.position, transform.rotation);
        //Get nearby objects
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radius);

        foreach (Collider2D nearbyObject in colliders)
        {
            Rigidbody2D rb = nearbyObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radius);
            }
        }
        StartCoroutine(RemoveGrenade());
        
    }

    IEnumerator RemoveGrenade()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(.2f);
        Destroy(gameObject);
    }
}
