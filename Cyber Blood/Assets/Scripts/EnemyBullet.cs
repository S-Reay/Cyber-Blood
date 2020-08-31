using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

	public float speed = 20f;
	public int damage = 40;
	public Rigidbody2D rb;
	public GameObject impactEffect;

	// Use this for initialization
	void Start () {
		rb.velocity = transform.right * speed;
	}

	void OnTriggerEnter2D (Collider2D hitInfo)
	{
		if (hitInfo.tag == "Enemy" || hitInfo.tag == "Ignore")
			return;

		Player_Health player = hitInfo.GetComponent<Player_Health>();
		if (player != null)
		{
			player.TakeDamage(damage, true);
		}

		Debug.Log("Tag " + hitInfo.tag);
		Debug.Log(hitInfo.name);

		Instantiate(impactEffect, transform.position, transform.rotation);

		Destroy(gameObject);
	}
	
}
