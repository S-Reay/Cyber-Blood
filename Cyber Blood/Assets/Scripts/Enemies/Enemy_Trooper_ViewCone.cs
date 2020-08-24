using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Trooper_ViewCone : MonoBehaviour
{
    private Enemy_Trooper baseScript;

    private bool isShooting = false;
    public GameObject bulletPrefab;
    public Transform firePoint;

    private void Awake()
    {
        baseScript = gameObject.GetComponentInParent<Enemy_Trooper>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !isShooting)
        {
            //Debug.Log(gameObject.name + " has detected player");
            StartCoroutine(Shoot());
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            baseScript.engaged = false;
        }
    }
    IEnumerator Shoot()
    {
        isShooting = true;
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        baseScript.engaged = true;
        yield return new WaitForSeconds(0.3f);
        isShooting = false;
    }
}
