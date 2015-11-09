using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	Transform player;
	Transform enemy;
	NavMeshAgent nav;
	public int moveDistance = 20, shootDistance = 100;

	public GameObject shot;
	public float fireRate = 500f;
	public float NextShot;
	Vector3 shotPosition;

	void Awake () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		enemy = this.gameObject.transform;
		nav = GetComponent <NavMeshAgent> ();
	}

	// Update is called once per frame
	void Update () {
		double distance = Vector3.Distance(player.position,enemy.position);
		if (distance > moveDistance && distance  > shootDistance) {
			nav.SetDestination (player.position);
			Debug.Log ("1: "+distance);
		}
		else if (distance > moveDistance && distance  <= shootDistance) {
			nav.SetDestination (player.position);
			Shoot();
			Debug.Log ("2: "+distance);
		} 
		else if (distance <= moveDistance) {
			Shoot();
			Debug.Log ("3: "+distance);
		} 
		else {
			Debug.Log (distance);
		}
	}
	void Shoot()
	{
		Debug.Log ("Shoot");
		NextShot = Time.time + fireRate;
		shotPosition = new Vector3(enemy.position.x,enemy.position.y+3,enemy.position.z);
		Instantiate(shot, shotPosition, enemy.rotation);
	}



}
