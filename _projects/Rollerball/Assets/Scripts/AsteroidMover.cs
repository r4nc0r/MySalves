﻿using UnityEngine;
using System.Collections;

public class AsteroidMover : MonoBehaviour {
    public float speed;
    // Use this for initialization
    void Start ()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }


}
