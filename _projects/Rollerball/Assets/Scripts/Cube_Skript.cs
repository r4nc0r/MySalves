using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Cube_Skript : MonoBehaviour
{

    public int attackDamage = 5;
    GameObject Player;
    PlayerHealth playerHealth;
    bool playerInRange;
    public Text myText;

    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = Player.GetComponent<PlayerHealth>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerInRange = true;
            Attack();
            Destroy(gameObject);

        }
        else if (other.tag == "Bolt")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
    void Update()
    {
        if (playerInRange)
        {
            playerInRange = false;
            Attack();
            Destroy(gameObject);
        }
    }
    void Attack()
    {
        SendMessage("TakeDamage", attackDamage);
        if (playerHealth.currentHealth > 0)
        {
            playerHealth.TakeDamage(attackDamage);

        }
    }
}
