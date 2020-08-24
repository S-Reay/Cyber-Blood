using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Weapons : MonoBehaviour
{
    public ProjectileWeapon missile;
    public RayCastWeapon shotgun;

    void Start()
    {
        missile = GetComponent<ProjectileWeapon>();
        shotgun = GetComponent<RayCastWeapon>();

        shotgun.enabled = true;
        missile.enabled = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Weapon 1"))
        {
            shotgun.enabled = true;
            missile.enabled = false;
        }
        else if (Input.GetButtonDown("Weapon 2"))
        {
            shotgun.enabled = false;
            missile.enabled = true;
        }
    }
}
