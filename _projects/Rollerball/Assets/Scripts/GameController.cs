using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject Player;
    public GameObject Boundary;
    private Vector3 offset;
    private Vector3 Pos = new Vector3();
    public GameObject Asteroids;
    public GameObject BonusItem;

    void Start()
    {
        offset = transform.position - Player.transform.position;
        SpawnAsteroids();
    }
    void SpawnAsteroids()
    {
        if (GameObject.FindGameObjectsWithTag("Asteroid").Length < 3)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-Pos.x + 40, Pos.x + 40), 1, Pos.z + 40);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(Asteroids, spawnPosition, spawnRotation);
        }
    }
    void SpawnBonusItems()
    {
        if (GameObject.FindGameObjectsWithTag("BonusItem").Length < 1 && Random.Range(0,1)>=0)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-Pos.x + 40, Pos.x + 40), 1, Pos.z + 40);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(BonusItem, spawnPosition, spawnRotation);
        }
    }
    void Update()
    {
        transform.position = Player.transform.position + offset;
        Pos = Boundary.transform.position;
        SpawnAsteroids();
        SpawnBonusItems();
    }

}
