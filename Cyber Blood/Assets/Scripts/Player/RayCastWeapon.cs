using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastWeapon : MonoBehaviour
{
	public int damage = 10;
	public GameObject impactEffect;
	public List<Transform> firePoints = new List<Transform>(5);
	public List<LineRenderer> lineRenderers = new List<LineRenderer>(5);
	public List<RaycastHit2D> hits = new List<RaycastHit2D>(5);

	[SerializeField]LayerMask ignoreLayerMask;
	private int notViewCones;

	public float startShotTimer = 0.7f;
	private float shotTimer;

	[SerializeField] private CameraShake cameraShake;
	public GameObject hitParticle;

	private void Awake()
	{
		notViewCones = ~ignoreLayerMask;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1") && shotTimer <= 0f)
		{
			StartCoroutine(Shoot());
			shotTimer = startShotTimer;
		}
		if (shotTimer > 0f)
		{
			shotTimer -= Time.deltaTime;
		}
	}

	IEnumerator Shoot ()
	{
		StartCoroutine(cameraShake.Shake(.15f, .065f));

		#region Hits
		hits.Clear();
		RaycastHit2D hitInfo0 = Physics2D.Raycast(firePoints[0].position, firePoints[0].right, 100, notViewCones);
		RaycastHit2D hitInfo1 = Physics2D.Raycast(firePoints[1].position, firePoints[1].right, 100, notViewCones);
		RaycastHit2D hitInfo2 = Physics2D.Raycast(firePoints[2].position, firePoints[2].right, 100, notViewCones);
		RaycastHit2D hitInfo3 = Physics2D.Raycast(firePoints[3].position, firePoints[3].right, 100, notViewCones);
		RaycastHit2D hitInfo4 = Physics2D.Raycast(firePoints[4].position, firePoints[4].right, 100, notViewCones);
		hits.Add(hitInfo0);
		hits.Add(hitInfo1);
		hits.Add(hitInfo2);
		hits.Add(hitInfo3);
		hits.Add(hitInfo4);
		#endregion

		for (int i = 0; i < hits.Count; i++)
		{
			Debug.Log(hits[i].transform.name);

			if (hits[i])
			{
				Enemy enemy = hits[i].transform.GetComponent<Enemy>();
				if (enemy != null)
				{
					enemy.TakeDamage(damage);
					Instantiate(hitParticle, hits[i].point, Quaternion.identity);
				}

				Instantiate(impactEffect, hits[i].point, Quaternion.identity);

				lineRenderers[i].SetPosition(0, firePoints[i].position);
				lineRenderers[i].SetPosition(1, hits[i].point);
			}
			else
			{
				lineRenderers[i].SetPosition(0, firePoints[i].position);
				lineRenderers[i].SetPosition(1, firePoints[i].position + firePoints[i].right * 100);
			}
		}

		for (int i = 0; i < lineRenderers.Count; i++)
		{
			lineRenderers[i].enabled = true;
		}

		yield return new WaitForSeconds(0.05f);

		for (int i = 0; i < lineRenderers.Count; i++)
		{
			lineRenderers[i].enabled = false;
		}
	}
}
