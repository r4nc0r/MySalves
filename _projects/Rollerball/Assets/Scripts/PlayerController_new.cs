using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController_new : MonoBehaviour
{
  public static Vector3 PlayerPos = new Vector3(0, 0, 0);


  public float forwardSpeed;
  public float straveSpeed;
  public int turnSpeed;

  public GameObject shot;
  public Transform shotSpawn;
  public float fireRate;
  public float NextShot;
  public Text pointsText;
  public Text moneyText;

  public int Points { get; set; }
  public int Money { get; set; }
    void Start()
  {
        Points = 0;
        Money = 0;
  }
  void Update()
  {
    if (Input.GetButton("Fire1") && NextShot <= Time.time)
    {
      NextShot = Time.time + fireRate;
      Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
    }
  }
  void FixedUpdate()
  {
    float moveForward = Input.GetAxis("Vertical");

    float moveStrave = Input.GetAxis("Horizontal");

    float turning = Input.GetAxis("Turning");

    float rotationAngle;

    Vector3 rotationAxis;

    transform.rotation.ToAngleAxis(out rotationAngle,out rotationAxis);

    Vector3 Strave = new Vector3(moveStrave * Mathf.Cos(rotationAngle), 0, moveStrave * Mathf.Sin(rotationAngle * -1 ));

    Vector3 Forward = new Vector3(moveForward * Mathf.Sin(rotationAngle), 0, moveForward * Mathf.Cos(rotationAngle));

    transform.Translate(Strave * straveSpeed);

    transform.Translate(Forward * forwardSpeed);
    transform.Rotate(new Vector3(0, 1, 0), turning * turnSpeed * Time.deltaTime);
    PlayerPos = transform.position;
  }

    public void SetMoneyText()
    {
        pointsText.text = "Money: " + moneyText.ToString();
    }
    public void SetPointText(int p)
    {
     pointsText.text = "Punkte: " + p.ToString();
    }
}

