using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowGrenade : MonoBehaviour
{
    public GameObject grenade;
    public Transform firePoint;
    public float throwForce;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Grenade"))
        {
            GameObject thrownGrenade = Instantiate(grenade, firePoint.position, firePoint.rotation);
            thrownGrenade.GetComponent<Rigidbody2D>().AddForce((Vector2.right + Vector2.up) * throwForce);
        }   
    }
}
