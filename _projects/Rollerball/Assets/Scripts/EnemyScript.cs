using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour
{
  public GameObject Enemy;
  // Dieses Skript wird nicht verwendet, aber hier kann man sehen wie GameObjects komplett im Codebehind erstellt werden.

  void Start()
  {
    for (int y = 0; y < 15; y++)
    {
      for (int x = 0; x < 15; x++)
      {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.AddComponent<Rigidbody>();
        cube.transform.position = new Vector3(x, y, 0);
      }
    }
  }

  // Update is called once per frame
  void Update () {
	
	}
}
