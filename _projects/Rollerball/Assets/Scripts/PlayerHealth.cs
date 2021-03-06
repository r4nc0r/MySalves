﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    GameObject Player;
    public Text deathText;

    void Awake ()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        currentHealth = startingHealth;
    }

    public void TakeDamage (int amount)
    {
        currentHealth -= amount;
        healthSlider.value = currentHealth;

        if (currentHealth <= 0)
        {
            Player.SetActive(false);
            deathText.text = "You Loser";
        }
          
    }

}
