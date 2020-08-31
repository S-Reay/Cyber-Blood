using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthKit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player_Health player = collision.GetComponent<Player_Health>();
        if (player != null)
        {
            player.health = player.maxHealth;
            player.TakeDamage(0, false);
            Destroy(gameObject);
        }
    }
}
