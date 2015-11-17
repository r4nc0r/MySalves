﻿using UnityEngine;
using System.Collections;

public class BonusItemHandler : MonoBehaviour
{
    public GameObject[] BonusItems;
    GameObject Player;
    int bonusItemIndex = 0;
    Vector3 yAxisAdd = new Vector3(0, 0, 0);
    Quaternion rotation = new Quaternion(0, 0, 0, 0);

    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == Player.tag || other.tag == "Bolt")
        {
            Destroy(gameObject);
            if (Random.Range(0, 100) <= 1)
            {
                bonusItemIndex = 0;
                yAxisAdd.y = 4;
                rotation= Quaternion.AngleAxis(180, new Vector3(0, 1, 0));
            }
            else
            {
                bonusItemIndex = 1;
                yAxisAdd.y = 0;
                rotation = transform.rotation;
            }
            Instantiate(BonusItems[bonusItemIndex], transform.position+ yAxisAdd, rotation);
        }
    }
}