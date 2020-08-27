using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int health = 100;

	public GameObject deathEffect;

	public void TakeDamage (int damage)
	{
		health -= damage;

		if (health <= 0)
		{
			StartCoroutine(Die());
		}
	}

	IEnumerator Die()
	{
		StartCoroutine(Camera.main.GetComponent<CameraShake>().Shake(.15f, .3f));
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		yield return new WaitForSeconds(.15f);
		Destroy(gameObject);
	}

}
