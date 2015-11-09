using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject enemies;
	public Transform spawnPoint;
	Vector3 spawnPointTemp;
	public int enemyCount;
  
	void Start()
	{
		for (int i = 0; i < enemyCount; i++) 
		{
			SpawnEnemies ();
		}
	}

	void SpawnEnemies()
	{
		spawnPointTemp.x = spawnPoint.position.x + Random.Range(1,20);
		spawnPointTemp.z = spawnPoint.position.z + Random.Range(1,20);
		Instantiate(enemies, spawnPointTemp , spawnPoint.rotation);
	}

	void Update()
	{
		if (GameObject.FindGameObjectsWithTag ("Enemy").Length < enemyCount) {
			SpawnEnemies ();
		}
	}
}
