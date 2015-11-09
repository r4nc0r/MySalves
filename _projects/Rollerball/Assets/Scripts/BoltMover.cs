using UnityEngine;
using System.Collections;

public class BoltMover : MonoBehaviour {
	public float speed;
	public float DestructionTime;
	float spawnTime;

	void Start ()
		{
		Rigidbody BoltRigidBody = GetComponent<Rigidbody>();
		BoltRigidBody.velocity = transform.forward * speed;
		spawnTime = Time.time;
	}
	void OnTriggerEnter(Collider other)
		{
		if (other.gameObject.CompareTag("Enemy"))
		{
//			Destroy(other.gameObject);
//			Destroy(this.gameObject);
//			other.gameObject.SetActive(false);
//			this.gameObject.SetActive(false);
		}
	}
<<<<<<< HEAD
}
=======
  void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("Pick Up"))
    {
            Destroy(other.gameObject);
    }
  }
}
>>>>>>> refs/remotes/origin/master
