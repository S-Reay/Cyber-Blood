using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragGrenade : MonoBehaviour
{
    public float delay;
    private float countdown;
    private bool hasExploded;

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
        StartCoroutine(RemoveGrenade());
        
    }

    IEnumerator RemoveGrenade()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(.2f);
        Destroy(gameObject);
    }
}
