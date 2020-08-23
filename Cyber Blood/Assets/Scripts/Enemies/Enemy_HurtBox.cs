using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_HurtBox : MonoBehaviour
{
    [SerializeField] private int damage = 25;
    [SerializeField] private bool givesInvincibility = true;
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.GetComponent<Player_Health>() != null)
        {
            Debug.Log(gameObject.name + "'s hitbox has collided with Player");
            collision.transform.GetComponent<Player_Health>().TakeDamage(damage, givesInvincibility);
        }
    }
}
