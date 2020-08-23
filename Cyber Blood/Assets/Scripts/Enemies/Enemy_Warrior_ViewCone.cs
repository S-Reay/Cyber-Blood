using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Warrior_ViewCone : MonoBehaviour
{
    private Enemy_Warrior baseScript;
    public float dashDelay = 0.3f;

    private void Awake()
    {
        baseScript = gameObject.GetComponentInParent<Enemy_Warrior>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !baseScript.isStunned && !baseScript.isDashing)
        {
            Debug.Log(gameObject.name + " has detected player");
            StartCoroutine(DashAttack());
        }
    }

    IEnumerator DashAttack()
    {
        //STOP MOVEMENT
        baseScript.isStunned = true;
        //BROADCAST ATTACK
        yield return new WaitForSeconds(dashDelay);
        baseScript.isStunned = false;
        baseScript.isDashing = true;
    }
}
