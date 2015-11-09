using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
    public int attackDamage = 50;
    public GameObject BoltExplosion;
    public GameObject Player;
    PlayerHealth playerHealth;
    private bool playerInRange;
    void Awake()
    {
        playerHealth = Player.GetComponent<PlayerHealth>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerInRange = true;
            Instantiate(BoltExplosion, transform.position, transform.rotation);
        }
        else if(other.tag=="Bolt")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Instantiate(BoltExplosion, transform.position, transform.rotation);
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
        if (playerHealth.currentHealth > 0)
        {
            playerHealth.TakeDamage(attackDamage);

        }
    }
}
