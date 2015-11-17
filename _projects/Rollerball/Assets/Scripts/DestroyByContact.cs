﻿using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
    public int attackDamage = 50;
    public GameObject BoltExplosion;
    GameObject Player;
    PlayerHealth playerHealth;
    PlayerController_new playerController;
    private bool playerInRange;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = Player.GetComponent("PlayerHealth") as PlayerHealth;
        playerController = Player.GetComponent<PlayerController_new>();
        
    }
    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = Player.GetComponent<PlayerHealth>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag ==Player.tag)
        {
            playerInRange = true;
            Instantiate(BoltExplosion, transform.position, transform.rotation);

        }
        else if(other.tag=="Bolt")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Instantiate(BoltExplosion, transform.position, transform.rotation);
            //SendMessage("SetPointText",100);
            //playerController.Points++;
            //playerController.SetPointText();
        }
    }
    void Update()
    {
        if (playerInRange)
        {
            playerInRange = false;
            Attack();
            Destroy(this.gameObject);
        }
    }
    void Attack()
    {
       // SendMessage("TakeDamage", 50);
        if (playerHealth.currentHealth > 0)
        {
            //SendMessage("TakeDamage", 50);
            playerHealth.TakeDamage(attackDamage);
        }
    }
}
