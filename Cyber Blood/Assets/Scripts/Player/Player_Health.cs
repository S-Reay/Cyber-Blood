using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour
{
    public int health = 100;
    public float invincibilityTime = 1.5f;
    public bool invincible = false;

    public void TakeDamage(int damage, bool invincibility)
    {
        if (invincible)
            return;
        health -= damage;
        if (health <= 0)
        {
            //PLAYER DIES
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);   //Reload current scene
        }
        if (invincibility)
        {
            //SHOW INVINCIBILITY
            StartCoroutine(Invincible());
        }
    }
    IEnumerator Invincible()
    {
        invincible = true;
        yield return new WaitForSeconds(invincibilityTime);
        invincible = false;
    }
}
