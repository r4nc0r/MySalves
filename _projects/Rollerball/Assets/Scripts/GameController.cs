using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

  public GameObject pickUps;
  public Vector3 spawnValues;
  public int PickUpsCount;
  
  void Start()
  {
    //SpawnPickUps();
  }

  //void SpawnPickUps()
  //{
  //  for (int i = 0; i < 100; i++)
  //  {
  //    Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, Random.Range(-spawnValues.z, spawnValues.z));
  //    Quaternion rotation = Quaternion.identity;
  //    Instantiate(pickUps, spawnPosition, rotation);
  //  }
  //}


}
