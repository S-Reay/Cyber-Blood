using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Weapons : MonoBehaviour
{
    public ProjectileWeapon missile;
    public RayCastWeapon shotgun;

    public Image missileImage;
    public Image shotgunImage;

    void Start()
    {
        missile = GetComponent<ProjectileWeapon>();
        shotgun = GetComponent<RayCastWeapon>();

        shotgun.enabled = true;
        missile.enabled = false;
        shotgunImage.enabled = true;
        missileImage.enabled = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Weapon 1"))
        {
            shotgun.enabled = true;
            missile.enabled = false;
            shotgunImage.enabled = true;
            missileImage.enabled = false;
        }
        else if (Input.GetButtonDown("Weapon 2"))
        {
            shotgun.enabled = false;
            missile.enabled = true;
            shotgunImage.enabled = false;
            missileImage.enabled = true;
        }
    }
}
