using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Warrior : Enemy
{
    public float speed;
    public float distance;

    private bool movingRight = true;

    public Transform groundDetection;
    private Rigidbody2D rb;

    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private float stunTime;
    public float startStunTime;
    public bool isDashing = false;
    public bool isStunned = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
        stunTime = startStunTime;
    }

    private void Update()
    {
        if (!isStunned)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if (groundInfo.collider == false)
        {
            if (isDashing)
            {
                isStunned = true;
                isDashing = false;
                Debug.Log("Stunned");
            }
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }

        if (isDashing)
        {
            dashTime -= Time.deltaTime;
            if (dashTime <= 0)
            {
                isDashing = false;
                dashTime = startDashTime;
                //rb.velocity = Vector2.zero;
            }
            else
            {
                if (movingRight)
                {
                    rb.velocity = Vector2.right * dashSpeed;
                }
                else
                {
                    rb.velocity = -Vector2.right * dashSpeed;
                }

            }
        }

        if (isStunned)
        {
            stunTime -= Time.deltaTime;
            if (stunTime <= 0)
            {
                isStunned = false;
                stunTime = startStunTime;
            }
        }
    }
}