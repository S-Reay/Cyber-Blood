using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour
{
    public float maxHealth = 100;
    public float health;
    public float invincibilityTime = 1.5f;
    public bool invincible = false;

    public Image healthBar;

    private void Awake()
    {
        health = maxHealth;
    }

    public void TakeDamage(int damage, bool invincibility)
    {
        if (invincible)
            return;
        health -= damage;
        Debug.Log("Setting " + healthBar.name + " to " + (health / maxHealth));
        healthBar.fillAmount = health / maxHealth;
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
