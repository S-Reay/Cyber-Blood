using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Gladiator_ViewCone : MonoBehaviour
{
    private Enemy_Gladiator baseScript;

    private bool isShooting = false;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public GameObject gunPivot;
    public float aimSpeed = 1f;

    private Transform target;
    private Vector3 targetPos;
    private Vector3 thisPos;
    private float angle;
    public float offset;

    public float shotSpeed = 0.5f;

    private void Awake()
    {
        baseScript = gameObject.GetComponentInParent<Enemy_Gladiator>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log(gameObject.name + " has detected player");
            Aim(collision.transform);
            if (!isShooting)
            {
                StartCoroutine(Shoot());
            }
        }
    }

    void Aim(Transform player)
    {

        targetPos = player.position;
        thisPos = gunPivot.transform.position;
        targetPos.x = targetPos.x - thisPos.x;
        targetPos.y = targetPos.y - thisPos.y;
        angle = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;

        gunPivot.transform.rotation = Quaternion.RotateTowards(gunPivot.transform.rotation, Quaternion.Euler(new Vector3(0, 0, angle + offset)), aimSpeed*Time.deltaTime);
    }

    IEnumerator Shoot()
    {
        isShooting = true;
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        yield return new WaitForSeconds(shotSpeed);
        isShooting = false;
    }
}
