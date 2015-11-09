using UnityEngine;
using UnityEngine.UI;

public class BondaryController : MonoBehaviour
{

  public GameObject Enemy;
  public GameObject pickUps;
  public GameObject Player;
  public GameObject Boundary;
  private NavMeshAgent movement;
  private Vector3 offset;
  private Vector3 Pos;
  // Use this for initialization
  void Start()
  {
    offset = transform.position - Player.transform.position;
    SpawnPickUps();
  }

  // Update is called once per frame
  void Update()
  {
    transform.position = Player.transform.position + offset;
    SpawnPickUps();
  }

  void SpawnPickUps()
  {
    if(GameObject.FindGameObjectsWithTag("Enemy").Length<15)
    {
	  Pos= new Vector3(Boundary.transform.position.x+Random.Range(-40,40),1,Boundary.transform.position.x+Random.Range(-40,40));
	  Quaternion rotation = Quaternion.identity;
      Instantiate(Enemy, Pos, rotation);
      
    }
  }
}