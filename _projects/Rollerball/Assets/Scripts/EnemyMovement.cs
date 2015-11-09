using UnityEngine;
using System.Collections;


public class EnemyMovement : MonoBehaviour {

    public GameObject player;
    private Vector3 pos;
	public NavMeshAgent navigation;
	// Use this for initialization
	void Start ()
    {
        
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        pos = player.transform.position;
        navigation.SetDestination(pos);
	}
}
