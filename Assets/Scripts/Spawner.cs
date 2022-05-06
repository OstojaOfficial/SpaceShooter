using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

	public GameObject prefab;

	float spawnDistance = 12f;

	float enemyRate = 5;
	float nextEnemy = 1;

	void Update ()
	{
		nextEnemy -= Time.deltaTime;

		if(nextEnemy <= 0)
		{
			nextEnemy = enemyRate;
			enemyRate *= 0.9f;
			if(enemyRate < 2)
				enemyRate = 2;

			Vector3 offset = Random.onUnitSphere;

			offset.z = 0;

			offset = offset.normalized * spawnDistance;

			Instantiate(prefab, transform.position + offset, Quaternion.identity);
		}
	}
}
